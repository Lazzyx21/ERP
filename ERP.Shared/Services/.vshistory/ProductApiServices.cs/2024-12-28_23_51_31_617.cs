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
    }
}