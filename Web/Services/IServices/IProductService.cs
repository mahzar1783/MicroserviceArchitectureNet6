﻿using Baseline.Web.Models;

namespace Baseline.Web.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>(string token);
        Task<T> GetProductByIdAsync<T>(int id, string token);
        Task<T> CreateProductAsync<T>(ProductRequestDto productDto, string token);
        Task<T> UpdateProductAsync<T>(ProductRequestDto productDto, string token);
        Task<T> DeleteProductAsync<T>(int id, string token);
    }
}
