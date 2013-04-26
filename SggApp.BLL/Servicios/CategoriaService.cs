using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL, como Categoria.
using SggApp.DAL.Repositorios; // Importa los repositorios de la capa DAL, necesarios para las operaciones de base de datos.
using SggApp.BLL.Interfaces; // Importa la interfaz ICategoriaService para que el servicio implemente los métodos definidos en ella.
using System.Collections.Generic; // Permite trabajar con colecciones, como listas e iteradores.
using System.Threading.Tasks; // Permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Servicios // Define el espacio de nombres de la capa de servicios.
{
    // Clase de servicio que implementa la interfaz ICategoriaService.
    public class CategoriaService : ICategoriaService
    {
        // Variable privada para almacenar el repositorio de categorías, inyectado a través del constructor.
        private readonly CategoriaRepository _categoriaRepository;

        // Constructor de la clase. Recibe un repositorio de categorías para ser utilizado en los métodos del servicio.
        public CategoriaService(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository; // Asigna el repositorio al campo privado.
        }

        // Método para obtener todas las categorías de manera asíncrona.
        public async Task<IEnumerable<Categoria>> ObtenerTodosAsync()
        {
            return await _categoriaRepository.GetAllAsync(); // Llama al método GetAllAsync del repositorio para obtener todas las categorías.
        }

        // Método para obtener una categoría específica por su ID de manera asíncrona.
        public async Task<Categoria> ObtenerPorIdAsync(int id)
        {
            return await _categoriaRepository.GetByIdAsync(id); // Llama al método GetByIdAsync del repositorio para obtener una categoría por su ID.
        }

        // Método para agregar una nueva categoría de manera asíncrona.
        public async Task AgregarAsync(Categoria categoria)
        {
            await _categoriaRepository.AddAsync(categoria); // Llama al método AddAsync del repositorio para agregar una nueva categoría.
        }

        // Método para actualizar una categoría existente de manera asíncrona.
        public async Task ActualizarAsync(Categoria categoria)
        {
            await _categoria_
