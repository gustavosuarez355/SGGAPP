using System.Collections.Generic; // Para IEnumerable
using System.Threading.Tasks; // Para Task
using SggApp.DAL.Entidades; // Para usar la entidad Categoria

namespace SggApp.DAL.Repositorios
{
    // Interfaz específica para las operaciones con la entidad Categoria
    public interface ICategoriaRepository : IGenericRepository<Categoria>
    {
        // Método para obtener todas las categorías activas
        Task<IEnumerable<Categoria>> ObtenerCategoriasActivasAsync();
    }
}
