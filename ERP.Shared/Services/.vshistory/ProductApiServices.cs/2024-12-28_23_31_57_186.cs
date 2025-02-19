using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

public class ProductApiServices
{
    private readonly HttpClient _httpClient;

    public ProductApiServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductsListResponse>> GetALLProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<ProductsListResponse>>("http://localhost:5163/api/controller/PList");
        return response ?? throw new Exception("Product details not found");
    }
}

