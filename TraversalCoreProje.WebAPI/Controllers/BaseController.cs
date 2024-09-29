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
            //No Content İçeriği değişebilir if yapısı kuruldu objectResult(null) 'Null Olarabilir' 
    
            if (response.StatusCode == 204) return new ObjectResult(response) { StatusCode = response.StatusCode };

            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}
