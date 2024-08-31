using Microsoft.AspNetCore.Mvc;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateAction<T>(ResponseDto<T> response)
        {
            if (response.StatusCode == 204) return new ObjectResult(null) { StatusCode = response.StatusCode };

            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}
