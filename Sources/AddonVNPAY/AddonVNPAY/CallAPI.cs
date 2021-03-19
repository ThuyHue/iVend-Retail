using AddonVNPAY.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Text;

namespace AddonVNPAY
{
    public class CallAPI
    {
        public static ApiResultCARD PaymentByCard(string data)
        {
            ApiResultCARD result = new ApiResultCARD();
            // Link test: http://payment.stage.tekoapis.net
            // Link Production: https://payment.tekoapis.net

            var client = new RestClient("http://payment.stage.tekoapis.net");
            var request = new RestRequest("api/transactions/spos", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            result = JsonConvert.DeserializeObject<ApiResultCARD>(response.Content);

            return result;
        }

        public static ApiResultQR PaymentByQR(string data)
        {
            ApiResultQR result = new ApiResultQR();
            // Link test: http://payment.stage.tekoapis.net
            // Link Production: https://payment.tekoapis.net

            var client = new RestClient("http://payment.stage.tekoapis.net");
            var request = new RestRequest("api/transactions/genqr", Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            result = JsonConvert.DeserializeObject<ApiResultQR>(response.Content);

            return result;
        }

        //public static ApiResultOrderDetail GetTransactionDetail(string data)
        //{
        //    ApiResultOrderDetail result = new ApiResultOrderDetail();
        //    // Link test: http://payment.stage.tekoapis.net
        //    // Link production: http://payment.tekoapis.net

        //    var client = new RestClient("https://payment.stage.tekoapis.net");
        //    var request = new RestRequest("api/transactions/filter", Method.GET);
        //    request.AddParameter("application/json", data, ParameterType.RequestBody);

        //    IRestResponse response = client.Execute(request);
        //    result = JsonConvert.DeserializeObject<ApiResultOrderDetail>(response.Content);

        //    return result;
        //}

        public static ApiResultOrderDetail GetTransactionDetail(ParameterRessulAPI data)
        {
            ApiResultOrderDetail result = new ApiResultOrderDetail();
            // Link test: http://payment.stage.tekoapis.net
            // Link production: http://payment.tekoapis.net

            var client = new RestClient("http://payment.stage.tekoapis.net");
            string action = string.Format("api/transactions/filter?client_code={0}&client_transaction_code={1}&ps_transaction_code={2}&checksum={3}", data.client_code, data.client_transaction_code, data.ps_transaction_code, data.checksum);
            var request = new RestRequest(action, Method.GET);

            IRestResponse response = client.Execute(request);
            result = JsonConvert.DeserializeObject<ApiResultOrderDetail>(response.Content);

            return result;
        }

        public static string CreateMD5(string str)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(str)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }
    }
}
