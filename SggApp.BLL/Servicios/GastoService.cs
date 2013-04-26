using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL, como Gasto.
using SggApp.DAL.Repositorios; // Importa los repositorios de la capa DAL, necesarios para las operaciones de base de datos.
using SggApp.BLL.Interfaces; // Importa la interfaz IGastoService para que el servicio implemente los métodos definidos en ella.
using System.Collections.Generic; // Permite trabajar con colecciones, como listas e iteradores.
using System.Threading.Tasks; // Permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Servicios // Define el espacio de nombres de la capa de servicios.
{
    // Clase de servicio que implementa la interfaz IGastoService.
    public class GastoService : IGastoService
    {
        // Variable privada para almacenar el repositorio de gastos, inyectado a través del constructor.
        private readonly GastoRepository _gastoRepository;

        // Constructor de la clase. Recibe un repositorio de gastos para ser utilizado en los métodos del servicio.
        public GastoService(GastoRepository gastoRepository)
        {
            _gastoRepository = gastoRepository; // Asigna el repositorio al campo privado.
        }

        // Método para obtener todos los gastos de manera asíncrona.
        public async Task<IEnumerable<Gasto>> ObtenerTodosAsync()
        {
            return await _gastoRepository.GetAllAsync(); // Llama al método GetAllAsync del repositorio para obtener todos los gastos.
        }

        // Método para obtener un gasto específico por su ID de manera asíncrona.
        public async Task<Gasto> ObtenerPorIdAsync(int id)
        {
            return await _gastoRepository.GetByIdAsync(id); // Llama al método GetByIdAsync del repositorio para obtener un gasto por su ID.
        }

        // Método para obtener los gastos de un usuario específico.
        public async Task<IEnumerable<Gasto>> ObtenerPorUsuarioAsync(int usuarioId)
        {
            return await _gastoRepository.GetByConditionAsync(g => g.UsuarioId == usuarioId); // Llama al método GetByConditionAsync del repositorio para obtener los gastos de un usuario.
        }

        // Método para agregar un nuevo gasto de manera asíncrona.
        public async Task AgregarAsync(Gasto gasto)
        {
            await _gastoRepository.AddAsync(gasto); // Llama al método AddAsync del repositorio para agregar un nuevo gasto.
        }

        // Método para actualizar un gasto existente de manera asíncrona.
        public async Task ActualizarAsync(Gasto gasto)
        {
            await _gastoRepository.UpdateAsync(gasto); // Llama al método UpdateAsync del repositorio para actualizar un gasto.
        }

        // Método para eliminar un gasto por su ID de manera asíncrona.
        public async Task EliminarAsync(int id)
        {
            var gasto = await _gastoRepository.GetByIdAsync(id); // Obtiene el gasto por su ID.
            if (gasto != null) // Si el gasto existe.
            {
                await _gastoRepository.DeleteAsync(gasto); // Llama al método DeleteAsync del repositorio para eliminar el gasto.
            }
        }
    }
}
