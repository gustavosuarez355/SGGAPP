using System.Collections.Generic; // Para usar List<T> y IEnumerable<T>
using System.Threading.Tasks;    // Para usar métodos asincrónicos

namespace SggApp.DAL.Repositorios
{
    // Interfaz genérica para operaciones CRUD básicas
    public interface IGenericRepository<T> where T : class
    {
        // Método para obtener un elemento por su ID
        Task<T?> ObtenerPorIdAsync(int id);  // Devuelve el elemento con el ID proporcionado

        // Método para obtener todos los elementos de una tabla
        Task<IEnumerable<T>> ObtenerTodosAsync();  // Devuelve todos los elementos de la entidad T

        // Método para agregar un nuevo elemento a la base de datos
        Task AgregarAsync(T entidad);  // Agrega una nueva entidad a la base de datos

        // Método para actualizar un elemento existente
        Task ActualizarAsync(T entidad);  // Actualiza una entidad existente en la base de datos

        // Método para eliminar un elemento de la base de datos
        Task EliminarAsync(T entidad);  // Elimina la entidad de la base de datos
    }
}
