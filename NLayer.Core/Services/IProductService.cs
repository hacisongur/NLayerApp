using NLayer.Core.DTOs;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductService:IService<Product>
    {//burda özelleşmiş bir response dönecez/Product ile beraber category de dönecez.ProductWithCategoryDto oluşturduk
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
