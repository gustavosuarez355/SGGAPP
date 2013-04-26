using SggApp.DAL.Entidades; // Importa las entidades relacionadas con la categoría.
using System.Collections.Generic; // Permite usar colecciones como IEnumerable.
using System.Threading.Tasks; // Permite trabajar con operaciones asíncronas.

namespace SggApp.BLL.Interfaces // Define el espacio de nombres de la capa BLL.
{
    // Interfaz para definir los métodos de la entidad Categoria.
    public interface ICategoriaService
    {
        // Método para obtener todas las categorías.
        Task<IEnumerable<Categoria>> ObtenerTodosAsync(); 
        
        // Método para obtener una categoría específica por su ID.
        Task<Categoria> ObtenerPorIdAsync(int id); 
        
        // Método para agregar una nueva categoría.
        Task AgregarAsync(Categoria categoria); 
        
        // Método para actualizar una categoría existente.
        Task ActualizarAsync(Categoria categoria); 
        
        // Método para eliminar una categoría por su ID.
        Task EliminarAsync(int id); 
    }
}
