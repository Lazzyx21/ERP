﻿using manufacturing_api.DTO.Response;
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

}