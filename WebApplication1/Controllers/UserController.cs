using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _usersService;

        public UserController(UserService usersService)
        {
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            var usuarios = _usersService.ObtenerTodosUsuarios();
            var roles = _usersService.ObtenerTodosRoles();
        }
    }
}
