using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL (Data Access Layer), donde se encuentran las clases de las entidades.
using System.Collections.Generic; // Importa el espacio de nombres que contiene la interfaz IEnumerable, utilizada para colecciones de objetos.
using System.Threading.Tasks; // Importa el espacio de nombres que permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Interfaces // Declara el espacio de nombres de la capa de lógica de negocio (BLL).
{
    // Interfaz que define los métodos necesarios para interactuar con la entidad Usuario en la capa de lógica de negocio.
    public interface IUsuarioService
    {
        // Método para obtener todos los usuarios de forma asíncrona.
        Task<IEnumerable<Usuario>> ObtenerTodosAsync(); 
        
        // Método para obtener un usuario por su ID, de forma asíncrona.
        Task<Usuario> ObtenerPorIdAsync(int id); 
        
        // Método para obtener un usuario por su correo electrónico, de forma asíncrona.
        Task<Usuario> ObtenerPorEmailAsync(string email); 
        
        // Método para agregar un nuevo usuario de forma asíncrona.
        Task AgregarAsync(Usuario usuario); 
        
        // Método para actualizar un usuario existente de forma asíncrona.
        Task ActualizarAsync(Usuario usuario); 
        
        // Método para eliminar un usuario de forma asíncrona, utilizando el ID.
        Task EliminarAsync(int id); 
    }
}


