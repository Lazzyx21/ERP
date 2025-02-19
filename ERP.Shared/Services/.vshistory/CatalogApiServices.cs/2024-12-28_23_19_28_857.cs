using Manufacturing_API.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services
{
    public class CatalogApiServices
    {
        private readonly HttpClient _httpClient;
        public CatalogApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<List<string>> CatalogListAsync(int ProductID)
        {
            var response = await _httpClient.GetFromJsonAsync<List<string>>($"http://localhost:5163/api/controller/catalogLists");
            return response ?? new List<string>();

        }
    }
}
