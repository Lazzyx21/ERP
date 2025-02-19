using Manufacturing_API.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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

        public async Task<List<ProductsListResponse>> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("http://localhost:5163/api/controller/PList");
            return response?.Data ?? new List<ProductsListResponse>();
        }


    }
}
