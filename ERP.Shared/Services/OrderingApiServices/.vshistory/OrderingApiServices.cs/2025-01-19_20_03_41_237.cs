using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services.Ordering
{
    public class OrderingApiServices
    {
        private readonly HttpClient _httpClient;
        public OrderingApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


    }
}
