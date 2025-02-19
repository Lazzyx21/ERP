using Manufacturing_API.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services.Ordering
{
    public class OrderingApiServices(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<ProductsListResponse>> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("http://localhost:5163/api/controller/PList");
            return response?.Data ?? new List<ProductsListResponse>();
        }

        public async Task<GenericApiResponse<List<OrderListResponse>>> GetOrdersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderListResponse>>>("");
            
        }


    }
}
