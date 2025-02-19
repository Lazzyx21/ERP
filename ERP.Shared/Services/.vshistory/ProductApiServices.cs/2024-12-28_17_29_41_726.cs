using Manufacturing_API.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services
{
    public class ProductApiServices
    {
        private readonly HttpClient _httpClient;

        public ProductApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductsListResponse>> GetProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("");
            if (response?.Status == 0)
                return response.Data;
            return new List<ProductsListResponse>();
        }
    }
}
