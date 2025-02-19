using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

public class ProductApiServices
{
    private readonly HttpClient _httpClient;

    public ProductApiServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ProductsListResponse> GetProductsAsync(int ProductID)
    {
        var response = await _httpClient.GetFromJsonAsync<ProductsListResponse>($"http://localhost:5163/api/controller/PList");
        return response ?? throw new Exception("Product details not found");
    }
}

