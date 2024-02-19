using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Data;
using System.Net.WebSockets;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase

    {
        private readonly AppDbContext _appDbContext;
        public ProductsController(AppDbContext appDbContext)
        {
            this._appDbContext=appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() {

            var Result =await _appDbContext.Products.ToListAsync();
            return Ok(Result);
        }
    }
}
