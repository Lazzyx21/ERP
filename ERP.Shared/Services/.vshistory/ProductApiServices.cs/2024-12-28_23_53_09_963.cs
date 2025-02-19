using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

public class ProductApiServices
{
    private readonly HttpClient _httpClient;

    public ProductApiServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductsListResponse>> GetProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("http://localhost:5163/api/controller/PList");
        if (response?.Status == 0)
            return response.Data;
        return new List<ProductsListResponse>();
    }
}