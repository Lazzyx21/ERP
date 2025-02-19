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
        {
            return response.Data;
        }
        return new List<EmployeeListResponse>();
    }

    public async Task<List<InventoryListResponse>> GetInventoryListAsync()
    {

    }

    public async Task<List<MachineListResponse>> GetMachinesListAsync()
    {

    }

    public async Task<List<OrderDetailsListResponse>> GetOrderDetailsAsync()
    {

    }

    public async Task<List<OrderListResponse>> GetOrdersAsync()
    {

    }

    public async Task<List<ProductsListResponse>> ProductsListsAsync()
    {

    }

    public async Task<List<QualityControlListResponse>> GetQualityControlListAsync()
    {

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