namespace AddonVNPAY.Models
{
    public class ParameterTransactionAPI
    {
        public string clientCode { get; set; }

        /// <summary>
        /// Mã điểm thu của Đối tác trên hệ thống Payment Hub.
        /// Được Payment Hub cung cấp riêng cho từng điểm thu, đi kèm nó là secretkey
        /// </summary>
        public string terminalCode { get; set; }

        /// <summary>
        /// Mã dịch vụ trên hệ thống Payment Hub
        /// </summary>
        public string serviceCode { get; set; }
        //public string mmc { get; set; }
        //public string ccy { get; set; }
        public string clientTransactionCode { get; set; }
        public string orderId { get; set; }
        public string orderCode { get; set; }
        public string orderDescription { get; set; }
        public long amount { get; set; }
        public string methodCode { get; set; } // Mã phương thức thanh toán
        public string partnerCode { get; set; } // Mã đối tác thanh toán
        public string metadata { get; set; }
        public string checksum { get; set; }

    }
    public class MetaData
    {
        public string payerName { get; set; }
        public string language { get; set; }
    }

    public class ParameterRessulAPI
    {
        public string client_code { get; set; }
        public string ps_transaction_code { get; set; }
        public string client_transaction_code { get; set; }
        public string checksum { get; set; }
    }
}
