using Microsoft.EntityFrameworkCore; // Necesario para trabajar con EF Core
using SggApp.DAL.Contextos;          // Importa el contexto de la base de datos
using SggApp.DAL.Entidades;          // Importa la entidad Usuario
using System.Threading.Tasks;        // Para tareas asincrónicas

namespace SggApp.DAL.Repositorios
{
    // Implementación concreta del repositorio de Usuario
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        // Constructor que recibe el contexto y lo pasa al repositorio genérico
        public UsuarioRepository(SggAppDbContext context) : base(context) { }

        // Aquí puedes agregar métodos personalizados específicos para Usuario
        // Ejemplo:
        // public async Task<Usuario?> ObtenerPorEmailAsync(string email)
        // {
        //     return await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
        // }
    }
}
