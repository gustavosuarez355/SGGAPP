using SggApp.DAL.Entidades; // Importa la entidad Usuario

namespace SggApp.DAL.Repositorios
{
    // Interfaz específica para la entidad Usuario que hereda las operaciones genéricas del repositorio genérico
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        // Aquí puedes agregar métodos personalizados específicos para Usuario si lo necesitas en el futuro
        // Por ejemplo:
        // Task<Usuario?> ObtenerPorEmailAsync(string email);
    }
}
