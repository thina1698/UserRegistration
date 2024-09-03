using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserCore.Interface;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPostEPPlusController : ControllerBase
    {
        private readonly IProductAddEPPlus _productAddEPPlus;

        public ProductPostEPPlusController( IProductAddEPPlus productAddEPPlus)
        {
            _productAddEPPlus = productAddEPPlus;
        }

        [HttpPost("UploadProductsFromExcel")]
        public async Task<IActionResult> UploadProducts(IFormFile file)
        {
            var (isSuccess, message) = await _productAddEPPlus.AddProductsFromExcel(file);

            if (!isSuccess)
                return BadRequest(message);

            return Ok(message);
        }
    }
}
