using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL, como Usuario.
using SggApp.DAL.Repositorios; // Importa los repositorios de la capa DAL, necesarios para las operaciones de base de datos.
using SggApp.BLL.Interfaces; // Importa la interfaz IUsuarioService para que el servicio implemente los métodos definidos en ella.
using System.Collections.Generic; // Permite trabajar con colecciones, como listas e iteradores.
using System.Threading.Tasks; // Permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Servicios // Define el espacio de nombres de la capa de servicios.
{
    // Clase de servicio que implementa la interfaz IUsuarioService.
    public class UsuarioService : IUsuarioService
    {
        // Variable privada para almacenar el repositorio de usuarios, inyectado a través del constructor.
        private readonly UsuarioRepository _usuarioRepository;

        // Constructor de la clase. Recibe un repositorio de usuarios para ser utilizado en los métodos del servicio.
        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository; // Asigna el repositorio al campo privado.
        }

        // Método para obtener todos los usuarios de manera asíncrona.
        public async Task<IEnumerable<Usuario>> ObtenerTodosAsync()
        {
            return await _usuarioRepository.GetAllAsync(); // Llama al método GetAllAsync del repositorio para obtener todos los usuarios.
        }

        // Método para obtener un usuario específico por su ID de manera asíncrona.
        public async Task<Usuario> ObtenerPorIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id); // Llama al método GetByIdAsync del repositorio para obtener un usuario por su ID.
        }

        // Método para obtener un usuario por su correo electrónico de manera asíncrona.
        public async Task<Usuario> ObtenerPorEmailAsync(string email)
        {
            return await _usuarioRepository.GetByConditionAsync(u => u.Email == email); // Llama al método GetByConditionAsync del repositorio para obtener un usuario por su email.
        }

        // Método para agregar un nuevo usuario de manera asíncrona.
        public async Task AgregarAsync(Usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario); // Llama al método AddAsync del repositorio para agregar un nuevo usuario a la base de datos.
        }

        // Método para actualizar un usuario existente de manera asíncrona.
        public async Task ActualizarAsync(Usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario); // Llama al método UpdateAsync del repositorio_
