﻿using Manufacturing_API.DTO.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Services
{
    public class CatalogApiServices
    {
        private readonly HttpClient _httpClient;
        public CatalogApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CatalogListResponse>> CatalogListAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<CatalogListResponse>>>("http://localhost:5163/api/controller/catalogLists");
            if (response?.Status == 200)
            {
                return response.Data;
            }
            return new List<CatalogListResponse>();

            //var response = await _httpClient.GetFromJsonAsync<GenericApiResponse<List<CatalogListResponse>>>("api/CatalogImage/images");
            //return response?.Status == 200 ? response.Data : null;
        }
    }
}
