
using Manufacturing_API.DTO.Response;
using System.Net.Http.Json;

public class ManufacturingApiService
{
    private readonly HttpClient _httpClient;

    public ManufacturingApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    /// <summary>
    /// Gets the bom list asynchronous.
    
    public async Task<List<BOMListResponse>> GetBomListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<BOMListResponse>>>("http://localhost:5163/api/controller/bomlistreponse");
        if (response?.Status == 0)
        
            return response.Data;
        
        return new List<BOMListResponse>();
    }

    public async Task<List<EmployeeListResponse>> GetEmployeesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<EmployeeListResponse>>>("http://localhost:5163/ap/controller/EList");
        if ((response?.Status == 0))
            return response.Data;

        return new List<EmployeeListResponse>();
    }

    public async Task<List<InventoryListResponse>> GetInventoryListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<InventoryListResponse>>>("http://localhost:5163/api/controller/IList");
        if (response?.Status == 0)
            return response.Data;
        return new List<InventoryListResponse>();
    }

    public async Task<List<MachineListResponse>> GetMachinesListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<MachineListResponse>>>("http://localhost:5163/api/controller/MList");
        if (response?.Status == 0)
            return response.Data;
        return new List<MachineListResponse>();
    }

    public async Task<List<OrderDetailsListResponse>> GetOrderDetailsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderDetailsListResponse>>>("http://localhost:5163/api/controller/ODList");
        if (response?.Status == 0)
            return response.Data;
        return new List<OrderDetailsListResponse>();
    }

    public async Task<List<OrderListResponse>> GetOrdersAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderListResponse>>>("http://localhost:5163/api/controller/OList");
        if (response?.Status == 0)
            return response.Data;
        return new List<OrderListResponse>();
    }

    

    public async Task<List<QualityControlListResponse>> GetQualityControlListAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<QualityControlListResponse>>>("http://localhost:5163/api/controller/QCList");
        if (response?.Status == 0)
            return response.Data;
        return new List<QualityControlListResponse>();
    }

    public async Task<List<RawMaterialsListResponse>> GetRawMaterialAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<RawMaterialsListResponse>>>("http://localhost:5163/api/controller/RWList");
        if (response?.Status == 0)
            return response.Data;
        return new List<RawMaterialsListResponse>();
    }

    public async Task<List<SupplierListResponse>> GetSupplierAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<SupplierListResponse>>>("http://localhost:5163/api/controller/SList");
        if (response?.Status == 0)
            return response.Data;
        return new List<SupplierListResponse>();
    }

    public async Task<List<WorkOrderListResponse>> GetWorkOrderListsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<WorkOrderListResponse>>>("http://localhost:5163/api/controller/WOList");
        if (response?.Status == 0)
            return response.Data;
        return new List<WorkOrderListResponse>();
    }

    public async Task<List<OrderProcessingResponse>> ListOrderProcessingAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<OrderProcessingResponse>>>("http://localhost:5163/api/controller/OrderProcessingList");
        if (response?.Status == 0)
            return response.Data;
        return new List<OrderProcessingResponse>();
    }

    

    /// </summary>
    /// The above code is all for GET API
    /// Return all the infromation from the Bill of materials table...
    /// <returns></returns>
    /// 

    //public async Task<List<>>


}