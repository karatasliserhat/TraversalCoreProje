using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.BusinessLayer.Interfaces.IUserServices;
using TraversolCoreProje.Dto.Dtos;
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
        [HttpPut]
        public async Task<IActionResult> UserEdit(UserEditDto userEditDto)
        {
            return CreateAction(await _userService.UserEditAsync(userEditDto));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return CreateAction(await _userService.GetUserAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUser(int id)
        {
            return CreateAction(await _userService.GetListUserAsync());
        }
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            return CreateAction(await _userService.DeleteUserAsync(userId));
        }
    }
}
