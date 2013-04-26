using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL, como Presupuesto.
using SggApp.DAL.Repositorios; // Importa los repositorios de la capa DAL, necesarios para las operaciones de base de datos.
using SggApp.BLL.Interfaces; // Importa la interfaz IPresupuestoService para que el servicio implemente los métodos definidos en ella.
using System.Collections.Generic; // Permite trabajar con colecciones, como listas e iteradores.
using System.Threading.Tasks; // Permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Servicios // Define el espacio de nombres de la capa de servicios.
{
    // Clase de servicio que implementa la interfaz IPresupuestoService.
    public class PresupuestoService : IPresupuestoService
    {
        // Variable privada para almacenar el repositorio de presupuestos, inyectado a través del constructor.
        private readonly PresupuestoRepository _presupuestoRepository;

        // Constructor de la clase. Recibe un repositorio de presupuestos para ser utilizado en los métodos del servicio.
        public PresupuestoService(PresupuestoRepository presupuestoRepository)
        {
            _presupuestoRepository = presupuestoRepository; // Asigna el repositorio al campo privado.
        }

        // Método para obtener todos los presupuestos de manera asíncrona.
        public async Task<IEnumerable<Presupuesto>> ObtenerTodosAsync()
        {
            return await _presupuestoRepository.GetAllAsync(); // Llama al método GetAllAsync del repositorio para obtener todos los presupuestos.
        }

        // Método para obtener un presupuesto específico por su ID de manera asíncrona.
        public async Task<Presupuesto> ObtenerPorIdAsync(int id)
        {
            return await _presupuestoRepository.GetByIdAsync(id); // Llama al método GetByIdAsync del repositorio para obtener un presupuesto por su ID.
        }

        // Método para agregar un nuevo presupuesto de manera asíncrona.
        public async Task AgregarAsync(Presupuesto presupuesto)
        {
            await _presupuestoRepository.AddAsync(presupuesto); // Llama al método AddAsync del repositorio para agregar un nuevo presupuesto.
        }

        // Método para actualizar un presupuesto existente de manera asíncrona.
        public async Task ActualizarAsync(Presupuesto presupuesto)
        {
            await _presupuestoRepository.UpdateAsync(presupuesto); // Llama al método UpdateAsync del repositorio para actualizar un presupuesto.
        }

        // Método para eliminar un presupuesto por su ID de manera asíncrona.
        public async Task EliminarAsync(int id)
        {
            var presupuesto = await _presupuestoRepository.GetByIdAsync(id); // Obtiene el presupuesto por su ID.
            if (presupuesto != null) // Si el presupuesto existe.
            {
                await _presupuestoRepository.DeleteAsync(presupuesto); // Llama al método DeleteAsync del repositorio para eliminar el presupuesto.
            }
        }
    }
}
