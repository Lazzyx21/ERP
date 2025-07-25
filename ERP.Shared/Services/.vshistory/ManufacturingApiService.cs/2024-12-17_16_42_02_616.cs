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
}