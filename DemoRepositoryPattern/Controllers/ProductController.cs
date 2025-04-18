using DemoRepositoryPattern.Infraestructure.Data;
using DemoRepositoryPattern.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoRepositoryPattern.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            var products = await _repository.GetAll();

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
