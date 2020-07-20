using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Model
{
    public class SqlOrderDetails : IOrderDetails
    {
        private WebClient _webClient;

        public SqlOrderDetails()
        {
            this._webClient = new WebClient();
        }
        public string GetOrderDetails(int id)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{\"userDetails\" : ");
            sb.Append(_webClient.DownloadString(Environment.GetEnvironmentVariable("UserServiceUrl") + "/api/user/" + id));

            sb.Append(",{\"orders\" : ");
            sb.Append(_webClient.DownloadString(Environment.GetEnvironmentVariable("OrderServiceUrl") + "/api/order/" + id));
            sb.Append("}");

            return sb.ToString();
        }
    }
}
