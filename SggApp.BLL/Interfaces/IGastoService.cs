using SggApp.DAL.Entidades; // Importa las entidades relacionadas con Gasto desde la capa DAL.
using System.Collections.Generic; // Permite el uso de colecciones como IEnumerable.
using System.Threading.Tasks; // Permite trabajar con operaciones asíncronas.

namespace SggApp.BLL.Interfaces // Define el espacio de nombres dentro de la capa BLL.
{
    // Interfaz para definir los métodos necesarios para la entidad Gasto en la capa de lógica de negocio.
    public interface IGastoService
    {
        // Método para obtener todos los gastos de forma asíncrona.
        Task<IEnumerable<Gasto>> ObtenerTodosAsync(); 
        
        // Método para obtener un gasto específico por su ID.
        Task<Gasto> ObtenerPorIdAsync(int id); 
        
        // Método para obtener los gastos de un usuario específico.
        Task<IEnumerable<Gasto>> ObtenerPorUsuarioAsync(int usuarioId); 
        
        // Método para agregar un nuevo gasto.
        Task AgregarAsync(Gasto gasto); 
        
        // Método para actualizar un gasto existente.
        Task ActualizarAsync(Gasto gasto); 
        
        // Método para eliminar un gasto por su ID.
        Task EliminarAsync(int id); 
    }
}
