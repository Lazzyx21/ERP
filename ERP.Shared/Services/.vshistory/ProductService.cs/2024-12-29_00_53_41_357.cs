using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductsListResponse>> GetProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("api/ManufacturingProducts");
        return response?.Data ?? new List<ProductsListResponse>();
    }
}

//public class ProductsListResponse
//{
//    public int ProductId { get; set; }
//    public string ProductName { get; set; }
//    public string Category { get; set; }
//    public decimal UnitPrice { get; set; }
//    public string Description { get; set; }
//}

//public class GenericApiResponse<T>
//{
//    public int Status { get; set; }
//    public string ErrorDesc { get; set; }
//    public T Data { get; set; }
//}
