namespace AddonVNPAY.Models
{
    #region VNPAY CARD
    public class ApiResultCARD
    {
        /// <summary>
        /// Theo format httpCode:
        /// 200: Thành công
        /// 401, 403: Thông tin clientCode hoặc mã hóa không hợp lệ
        /// 400: Dữ liệu không đúng định dạng hoặc lỗi nghiệp vụ
        /// </summary>
        public virtual int code { get; set; }

        /// <summary>
        /// True: Thành công, False: Thất bại
        /// </summary>
        public virtual bool success { get; set; }

        /// <summary>
        /// Mô tả chi tiết lỗi trong trường hợp thất bại
        /// </summary>
        public virtual string message { get; set; }

        /// <summary>
        /// Dữ liệu trả về trong trường hợp thành công
        /// </summary>
        public virtual SuccessDataCARD data { get; set; }

        /// <summary>
        /// Dữ liệu trả về trong trường hợp thất bại
        /// </summary>
        public virtual ErrorDataCARD errors { get; set; }
    }
    public class SuccessDataCARD
    {
        public string merchantPartnerCode { get; set; }

        /// <summary>
        /// Mã giao dịch trên hệ thống Payment Hub của VNPAY
        /// </summary>
        public string psTransactionCode { get; set; }
    }
    public class ErrorDataCARD
    {
        /// <summary>
        /// Loại lỗi
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Mã lỗi của hệ thống
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Mô tả lỗi
        /// </summary>
        public string message { get; set; }
    }
    #endregion

    #region VNPAY QR
    public class ApiResultQR
    {
        /// <summary>
        /// Theo format httpCode:
        /// 200: Thành công
        /// 401, 403: Thông tin clientCode hoặc mã hóa không hợp lệ
        /// 400: Dữ liệu không đúng định dạng hoặc lỗi nghiệp vụ
        /// </summary>
        public virtual int code { get; set; }

        /// <summary>
        /// True: Thành công, False: Thất bại
        /// </summary>
        public virtual bool success { get; set; }

        /// <summary>
        /// Mô tả chi tiết lỗi trong trường hợp thất bại
        /// </summary>
        public virtual string message { get; set; }

        /// <summary>
        /// Dữ liệu trả về trong trường hợp thành công
        /// </summary>
        public virtual SuccessDataQR data { get; set; }

        /// <summary>
        /// Dữ liệu trả về trong trường hợp thất bại
        /// </summary>
        public virtual ErrorDataQR errors { get; set; }
    }

    public class SuccessDataQR
    {
        public string qrcontent { get; set; }

        public string message { get; set; }

        /// <summary>
        /// Mã giao dịch trên hệ thống Payment Hub của VNPAY
        /// </summary>
        public string psTransactionCode { get; set; }
    }
    public class ErrorDataQR
    {
        /// <summary>
        /// Loại lỗi
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Mã lỗi của hệ thống
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Mô tả lỗi
        /// </summary>
        public string message { get; set; }
    }
    #endregion

    #region TRANSACTION DETAIL
    public class ApiResultOrderDetail
    {
        public string code { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public SuccessResultData data { get; set; }
    }

    public class SuccessResultData
    {
        public int id { get; set; }
        public string psTransactionCode { get; set; }
        public string agentCode { get; set; }
        public string agentName { get; set; }
        public string terminalType { get; set; }
        public string terminalTypeName { get; set; }
        public string serviceCode { get; set; }
        public string serviceName { get; set; }
        public string orderId { get; set; }
        public string orderCode { get; set; }
        public string terminalCode { get; set; }
        public string terminalName { get; set; }
        public int amount { get; set; }
        public string partnerCode { get; set; }
        public string partnerName { get; set; }
        public string methodCode { get; set; }
        public string methodName { get; set; }
        public string returnUrl { get; set; }
        public string partnerResponseCode { get; set; }
        public string status { get; set; }
        public string statusName { get; set; }
        public string psResponseCode { get; set; }
        public string psResponseMessage { get; set; }
        public string currency { get; set; }
        public string cardNo { get; set; }
        public string buyerEmail { get; set; }
        public string buyerPhone { get; set; }
        public string message { get; set; }
        public string installment { get; set; }
        public string is3D { get; set; }
        public string paymentTerm { get; set; }
        public string bankCode { get; set; }
        public string bankName { get; set; }
        public string orderDescription { get; set; }
        public string cardType { get; set; }
        public string bankHotline { get; set; }
        public string merchantFee { get; set; }
        public string payerFee { get; set; }
        public string partnerTransactionCode { get; set; }
        public string clientTransactionCode { get; set; }
        public string clientRequestTime { get; set; }
        public string clientResponseTime { get; set; }
        public string psRequestTime { get; set; }
        public string psResponseTime { get; set; }
        public string opsTime { get; set; }
        public string clientRetryCount { get; set; }
        public string psRetryCount { get; set; }
        public string asiaStaffId { get; set; }
        public string asiaPartnerId { get; set; }
        public string crmStaffId { get; set; }
        public string crmPartnerId { get; set; }
        public string partnerTerminalId { get; set; }
        public string provinceCode { get; set; }
        public string provinceName { get; set; }
        public string districtCode { get; set; }
        public string districtName { get; set; }
        public string buyerAddress { get; set; }
        public string customerPhone { get; set; }
        public string buyerName { get; set; }
        public string shippingType { get; set; }
        public SuccessResultMetaData metadata { get; set; }
        public string qrContent { get; set; }
    }

    public class SuccessResultMetaData
    {
        public string language { get; set; }
        public string payerName { get; set; }
    }
    #endregion
}
