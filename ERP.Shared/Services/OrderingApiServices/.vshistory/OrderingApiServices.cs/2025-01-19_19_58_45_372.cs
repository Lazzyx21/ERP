using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services.Ordering
{
    public class ShoppingBag
    {
        private readonly HttpClient _httpClient;
        public ShoppingBag(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
