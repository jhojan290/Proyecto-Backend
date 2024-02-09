using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public List<Roles> ObtenerTodosRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
