using manufacturing_api.DTO.Response;
using System.Net.Http.Json;

public class ManufacturingApiService
{
    private readonly HttpClient _httpClient;

    public ManufacturingApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<BOMListResponse>> GetBomListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<BOMListResponse>>>("http://localhost:5163/api/controller/bomlistreponse");
        if (response?.Status == 0)
        {
            return response.Data;
        }
        return new List<BOMListResponse>();
    }

    public async Task<List<EmployeeListResponse>> GetEmployeesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<EmployeeListResponse>>>("");
        if ((response?.Status == 0))
            return response.Data;
        
        return new List<EmployeeListResponse>();
    }

    public async Task<List<InventoryListResponse>> GetInventoryListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<InventoryListResponse>>>("");
        if(response?.Status == 0)
            return response.Data;
        return new List<InventoryListResponse>();
    }

    public async Task<List<MachineListResponse>> GetMachinesListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<MachineListResponse>>>("");
        if(response?.Status == 0
            return response.Data;
        return new List<MachineListResponse>();
    }

    public async Task<List<OrderDetailsListResponse>> GetOrderDetailsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderDetailsListResponse>>>("");
        if(response?.Status == 0)
            return response.Data;
        return new List<OrderDetailsListResponse>();
    }

    public async Task<List<OrderListResponse>> GetOrdersAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderListResponse>>>("");
        if(response?.Status == 0)
            return response.Data;
        return new List<OrderListResponse>();
    }

    public async Task<List<ProductsListResponse>> ProductsListsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<ProductsListResponse>>>("");
        if (response?.Status == 0)
            return response.Data;
        return new List<ProductsListResponse>();
    }

    public async Task<List<QualityControlListResponse>> GetQualityControlListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<QualityControlListResponse>>>("");
        if (response?.Status == 0)
            return response.Data;
        return new List<QualityControlListResponse>();
    }

    public async Task<List<RawMaterialsListResponse>> GetRawMaterialAsync()
    {

    }

    public async Task<List<SupplierListResponse>> GetSupplierAsync()
    {

    }

    public async Task<List<WorkOrderListResponse>> GetWorkOrderListsAsync()
    {

    }
}