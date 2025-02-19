using Manufacturing_API.DTO.Request;
using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

public class ProductsApiService
{
    private readonly HttpClient _httpClient;

    public ProductsApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductsListResponse>> GetProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("http://localhost:5163/api/controller/PList");
        if (response?.Status == 200)
        {
            return response.Data;
        }
        return new List<ProductsListResponse>();
    }

    public async<Task<string>> UpdateProductDetailsAsync(ProductRequest UpdateproductDetailsRequest)
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<string>>("http://localhost:5163/api/controller/UpdateProducts");
        if(response?.Status == 200)
        {
            return response.Data;
        }
        
    }
}
