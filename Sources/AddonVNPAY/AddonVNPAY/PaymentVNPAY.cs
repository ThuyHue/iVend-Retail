using AddonVNPAY.Models;
using CXS.Platform.DomainObjects;
using CXS.Retail.Extensibility;
using CXS.Retail.Extensibility.Modules.Transaction;
using CXS.SubSystem.Payment;
using CXS.SubSystem.Transaction;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AddonVNPAY
{
    class PaymentVNPAY : TransactionPaymentModuleBase
    {
        // Bắt sự kiện trước khi user click button OK trong màn hình thanh toán (sau khi đã chọn phương thức thanh toán)
        public override void OnBeforeAddPayment(object sender, EventArgs<Transaction, TransactionPayment> args)
        {
            Transaction tran = args.Item;
            var a = tran.TransactionSaleAttributes;
            TransactionPayment tranPayment = args.ChildItem;

            // TransactionkeyVNPAY: Tên của SaleAttribute do user tạo ra để lưu thêm key khi tạo transaction gửi sang VNPAY
            TransactionSaleAttribute transactionkeyVNPAY = tran.TransactionSaleAttributes.FirstOrDefault(p => p.SaleAttribute.Name == "TransactionkeyVNPAY");

            string popMappingFile = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + "\\Models\\POSMapping.json";
            string popMappingText = File.ReadAllText(popMappingFile);
            List<POSMapping> lstPOSMapping = JsonConvert.DeserializeObject<List<POSMapping>>(popMappingText);

            // Lấy thông tin máy mPOS tương ứng với từng điểm bán hàng đã được setup
            POSMapping objMapping = lstPOSMapping.FirstOrDefault(x => x.StoreKey == tran.StoreKey && x.POSKey == tran.POSKey);
            if(objMapping == null)
            {
                XtraMessageBox.Show("Không tìm thấy máy mPOS.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
                return;
            }
            string terminalCode = objMapping.TerminalCode;

            TenderType paytype = tranPayment.PaymentType.Type;
            string id = tranPayment.PaymentType.Id;
            if (paytype == TenderType.Custom && id == "VNPAYCard")
            {
                // Tạo metadata
                MetaData data = new MetaData();
                data.payerName = tran.TransactionCustomerName;
                data.language = "vi";
                string metadata = JsonConvert.SerializeObject(data);

                // Tạo parameter call API
                ParameterTransactionAPI para = new ParameterTransactionAPI();
                para.amount = Money.ToInt64(tran.Total);
                para.clientCode = "FTI";
                para.clientTransactionCode = Guid.NewGuid().ToString();
                para.metadata = "METAVALUE";
                para.methodCode = "SPOSCARD";
                para.orderCode = Guid.NewGuid().ToString();
                para.orderDescription = "";
                para.orderId = Guid.NewGuid().ToString();
                para.partnerCode = "VNPAY";
                para.serviceCode = "RETAIL";
                para.terminalCode = terminalCode;

                var strParaBody = string.Format("{0}amount={1}&clientCode={2}&clientTransactionCode={3}&metadata=METAVALUE&methodCode=SPOSCARD&orderCode={4}&orderDescription={5}&orderId={6}&partnerCode=VNPAY&serviceCode=RETAIL&terminalCode={7}", "b8399f824670b0bf07c84267ca9b1dff", para.amount, para.clientCode, para.clientTransactionCode, para.orderCode, para.orderDescription, para.orderId, para.terminalCode);
                strParaBody = strParaBody.Replace("METAVALUE", metadata);
                strParaBody = strParaBody.Replace("\"{", "{").Replace("}\"", "}");
                para.checksum = CallAPI.CreateMD5(strParaBody);

                string strPara = JsonConvert.SerializeObject(para);
                strPara = strPara.Replace("METAVALUE", metadata);
                strPara = strPara.Replace("\"{", "{").Replace("}\"", "}");

                // Call API để tạo Transaction
                ApiResultCARD resultPaymentVNPAYCard = CallAPI.PaymentByCard(strPara);
                // Tạo giao dịch thanh toán bằng VNPAY Card bị lỗi => Thông báo cho user biết lỗi
                if (!resultPaymentVNPAYCard.success)
                {
                    XtraMessageBox.Show(resultPaymentVNPAYCard.message, "Thông báo", MessageBoxButtons.OK);
                    args.Cancel = true;
                    return;
                }

                Thread.Sleep(15000); // Đợi 15s trước khi call API tra cứu kết quả
                bool tryGetDetail = true;
                while (tryGetDetail)
                {
                    Thread.Sleep(5000);

                    // Tạo giao dịch thanh toán bằng VNPAY Card thành công => Gọi API lấy kết quả giao dịch.
                    ParameterRessulAPI paraResult = new ParameterRessulAPI();
                    paraResult.client_code = para.clientCode;
                    paraResult.client_transaction_code = para.clientTransactionCode;
                    paraResult.ps_transaction_code = resultPaymentVNPAYCard.data.psTransactionCode;

                    var strParaResultBody = string.Format("{0}client_code={1}&client_transaction_code={2}&ps_transaction_code={3}", "b8399f824670b0bf07c84267ca9b1dff", paraResult.client_code, paraResult.client_transaction_code, paraResult.ps_transaction_code);
                    paraResult.checksum = CallAPI.CreateMD5(strParaResultBody);
                    string strParaResult = JsonConvert.SerializeObject(paraResult);

                    ApiResultOrderDetail resultOrderDetail = CallAPI.GetTransactionDetail(paraResult);
                    if (!resultOrderDetail.success)
                    {
                        XtraMessageBox.Show("Lấy kết quả giao dịch lỗi: " + resultOrderDetail.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        args.Cancel = true;
                        return;
                    }
                    else
                    {
                        if (resultOrderDetail.data.psResponseCode == null)
                        {
                            tryGetDetail = true;
                        }
                        else if (resultOrderDetail.data.psResponseCode == "000")
                        {
                            XtraMessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transactionkeyVNPAY.AttributeValue = para.clientTransactionCode;
                            tran.TransactionSaleAttributes.Add(transactionkeyVNPAY);
                            tryGetDetail = false;
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Giao dịch thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tryGetDetail = false;
                            args.Cancel = true;
                            return;
                        }
                    }

                }
            }

            else if (paytype == TenderType.Custom && id == "VNPAYQRCode")
            {
                // Tạo metadata
                MetaData data = new MetaData();
                data.payerName = tran.TransactionCustomerName;
                data.language = "vi";
                string metadata = JsonConvert.SerializeObject(data);

                // Tạo parameter call API
                ParameterTransactionAPI para = new ParameterTransactionAPI();
                para.amount = Money.ToInt64(tran.Total);
                para.clientCode = "FTI";
                para.clientTransactionCode = Guid.NewGuid().ToString();
                para.metadata = "METAVALUE";
                para.methodCode = "QRCODE";
                para.orderCode = Guid.NewGuid().ToString();
                para.orderDescription = "";
                para.orderId = Guid.NewGuid().ToString();
                para.partnerCode = "VNPAY";
                para.serviceCode = "RETAIL";
                para.terminalCode = terminalCode;

                var strParaBody = string.Format("{0}amount={1}&clientCode={2}&clientTransactionCode={3}&metadata=METAVALUE&methodCode=QRCODE&orderCode={4}&orderDescription={5}&orderId={6}&partnerCode=VNPAY&serviceCode=RETAIL&terminalCode={7}", "b8399f824670b0bf07c84267ca9b1dff", para.amount, para.clientCode, para.clientTransactionCode, para.orderCode, para.orderDescription, para.orderId, para.terminalCode);
                strParaBody = strParaBody.Replace("METAVALUE", metadata);
                strParaBody = strParaBody.Replace("\"{", "{").Replace("}\"", "}");
                para.checksum = CallAPI.CreateMD5(strParaBody);

                string strPara = JsonConvert.SerializeObject(para);
                strPara = strPara.Replace("METAVALUE", metadata);
                strPara = strPara.Replace("\"{", "{").Replace("}\"", "}");

                // Call API để tạo Transaction
                ApiResultQR resultPaymentVNPAYQR = CallAPI.PaymentByQR(strPara);
                // Tạo giao dịch thanh toán bằng VNPAY QR bị lỗi => Thông báo cho user biết lỗi
                if (!resultPaymentVNPAYQR.success)
                {
                    XtraMessageBox.Show(resultPaymentVNPAYQR.message, "Thông báo", MessageBoxButtons.OK);
                    args.Cancel = true;
                    return;
                }

                Thread.Sleep(15000); // Đợi 15s trước khi call API tra cứu kết quả
                bool tryGetDetail = true;
                while (tryGetDetail)
                {
                    Thread.Sleep(5000);

                    // Tạo giao dịch thanh toán bằng VNPAY Card thành công => Gọi API lấy kết quả giao dịch.
                    ParameterRessulAPI paraResult = new ParameterRessulAPI();
                    paraResult.client_code = para.clientCode;
                    paraResult.client_transaction_code = para.clientTransactionCode;
                    paraResult.ps_transaction_code = resultPaymentVNPAYQR.data.psTransactionCode;

                    var strParaResultBody = string.Format("{0}client_code={1}&client_transaction_code={2}&ps_transaction_code={3}", "b8399f824670b0bf07c84267ca9b1dff", paraResult.client_code, paraResult.client_transaction_code, paraResult.ps_transaction_code);
                    paraResult.checksum = CallAPI.CreateMD5(strParaResultBody);
                    string strParaResult = JsonConvert.SerializeObject(paraResult);

                    ApiResultOrderDetail resultOrderDetail = CallAPI.GetTransactionDetail(paraResult);
                    if (!resultOrderDetail.success)
                    {
                        XtraMessageBox.Show("Lấy kết quả giao dịch lỗi: " + resultOrderDetail.message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        args.Cancel = true;
                        return;
                    }
                    else
                    {
                        if (resultOrderDetail.data.psResponseCode == null)
                        {
                            tryGetDetail = true;
                        }
                        else if (resultOrderDetail.data.psResponseCode == "000")
                        {
                            XtraMessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            transactionkeyVNPAY.AttributeValue = para.clientTransactionCode;
                            tran.TransactionSaleAttributes.Add(transactionkeyVNPAY);
                            tryGetDetail = false;
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Giao dịch thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tryGetDetail = false;
                            args.Cancel = true;
                            return;
                        }
                    }

                }
            }
        }
    }
}
