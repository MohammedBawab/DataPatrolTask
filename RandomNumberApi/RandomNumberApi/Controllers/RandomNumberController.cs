using Microsoft.AspNetCore.Mvc;

namespace RandomNumberApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RandomNumberController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRandomNumber()
        {
            var random = new Random();

            var result = new
            {
                Data = new
                {
                    Number = random.Next(1, 11)
                }
            };

            return Ok(result);
        }
    }
}