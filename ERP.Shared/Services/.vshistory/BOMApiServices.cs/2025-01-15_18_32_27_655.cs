using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

namespace ERP.Shared.Services
{
    public class BOMApiServices
    {
        private readonly HttpClient _httpClient;
        public BOMApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<BOMListResponse>> GetBomListAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<BOMListResponse>>>("http://localhost:5163/api/controller/bomlistreponse");
            if(response?.Status == 200)
            {
                return response.Data;
            }
            return new List<BOMListResponse>
        }
    }
}
