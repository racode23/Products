using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Repository;
using System.Net.WebSockets;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase

    {
        private readonly ProductRepository _ProductRepository;
        public ProductsController(ProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(int id) {
           var result = _ProductRepository.getById(id);

            return Ok(result);
        }
    }
}
