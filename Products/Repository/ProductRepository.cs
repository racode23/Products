using Microsoft.AspNetCore.Mvc;

namespace Products.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IActionResult GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> getAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
