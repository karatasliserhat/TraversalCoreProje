using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces.IUserServices;
using TraversolCoreProje.Dto.Dtos.UserDto;

namespace TraversalCoreProje.WebAPI.Controllers
{

    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> UserCreate(CreateUserDto createUserDto)
        {

            return CreateAction(await _userService.CreateUserAsync(createUserDto));
        }
    }
}
