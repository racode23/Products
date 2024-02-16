using Microsoft.AspNetCore.Mvc;

namespace Products.Repository
{
    public interface IProductRepository
    {
        public IActionResult GetAllProduct();
        public Task<IActionResult> getAllProduct();
    }
}
