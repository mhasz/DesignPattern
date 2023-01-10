using AbstractFactory.Clients;
using AbstractFactory.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Consumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbstractFactoryController : ControllerBase
    {
        [HttpGet]
        [Route("food")]
        public IActionResult SearchFood([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);
            var foods = productClient.SearchFood();

            if (foods == null)
                return BadRequest();

            return Ok(foods);
        }

        [HttpGet]
        [Route("packing")]
        public IActionResult SearchPacking([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);
            var packings = productClient.SearchPacking();

            if (packings == null)
                return BadRequest();

            return Ok(packings);
        }
    }
}
