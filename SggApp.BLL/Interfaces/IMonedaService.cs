using SggApp.DAL.Entidades; // Importa las entidades relacionadas con la moneda.
using System.Collections.Generic; // Permite usar colecciones como IEnumerable.
using System.Threading.Tasks; // Permite trabajar con operaciones asíncronas.

namespace SggApp.BLL.Interfaces // Define el espacio de nombres de la capa BLL.
{
    // Interfaz para definir los métodos de la entidad Moneda.
    public interface IMonedaService
    {
        // Método para obtener todas las monedas.
        Task<IEnumerable<Moneda>> ObtenerTodosAsync(); 
        
        // Método para obtener una moneda por su ID.
        Task<Moneda> ObtenerPorIdAsync(int id); 
        
        // Método para agregar una nueva moneda.
        Task AgregarAsync(Moneda moneda); 
        
        // Método para actualizar una moneda existente.
        Task ActualizarAsync(Moneda moneda); 
        
        // Método para eliminar una moneda por su ID.
        Task EliminarAsync(int id); 
    }
}
