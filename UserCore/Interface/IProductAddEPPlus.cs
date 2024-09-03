using Microsoft.AspNetCore.Http;

namespace UserCore.Interface
{
    public interface IProductAddEPPlus
    {
        Task<(bool isSuccess, string message)> AddProductsFromExcel(IFormFile file);
    }
}