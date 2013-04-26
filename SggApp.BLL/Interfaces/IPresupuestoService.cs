using SggApp.DAL.Entidades; // Importa las entidades relacionadas con el presupuesto.
using System.Collections.Generic; // Permite usar colecciones como IEnumerable.
using System.Threading.Tasks; // Permite trabajar con operaciones asíncronas.

namespace SggApp.BLL.Interfaces // Define el espacio de nombres de la capa BLL.
{
    // Interfaz para definir los métodos de la entidad Presupuesto.
    public interface IPresupuestoService
    {
        // Método para obtener todos los presupuestos.
        Task<IEnumerable<Presupuesto>> ObtenerTodosAsync(); 
        
        // Método para obtener un presupuesto por su ID.
        Task<Presupuesto> ObtenerPorIdAsync(int id); 
        
        // Método para agregar un nuevo presupuesto.
        Task AgregarAsync(Presupuesto presupuesto); 
        
        // Método para actualizar un presupuesto existente.
        Task ActualizarAsync(Presupuesto presupuesto); 
        
        // Método para eliminar un presupuesto por su ID.
        Task EliminarAsync(int id); 
    }
}
