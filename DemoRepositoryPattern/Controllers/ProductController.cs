using DemoRepositoryPattern.Infraestructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoRepositoryPattern.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult All()
        {
            var products = _context.Products.AsNoTracking().ToList();

            return Ok(products);
        }

        [HttpPost]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok();
        }
    }
}
