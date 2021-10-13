using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductBrandController : ControllerBase
    {
         private readonly IProductBrandRepository _repository;

        public ProductBrandController(IProductBrandRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrandAsync()
        {
            return Ok(await _repository.GetProductBrandAsync());
        }
    }
}