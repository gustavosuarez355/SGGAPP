using SggApp.DAL.Entidades; // Importa las entidades de la capa DAL, como Moneda.
using SggApp.DAL.Repositorios; // Importa los repositorios de la capa DAL, necesarios para las operaciones de base de datos.
using SggApp.BLL.Interfaces; // Importa la interfaz IMonedaService para que el servicio implemente los métodos definidos en ella.
using System.Collections.Generic; // Permite trabajar con colecciones, como listas e iteradores.
using System.Threading.Tasks; // Permite trabajar con tareas asíncronas.

namespace SggApp.BLL.Servicios // Define el espacio de nombres de la capa de servicios.
{
    // Clase de servicio que implementa la interfaz IMonedaService.
    public class MonedaService : IMonedaService
    {
        // Variable privada para almacenar el repositorio de monedas, inyectado a través del constructor.
        private readonly MonedaRepository _monedaRepository;

        // Constructor de la clase. Recibe un repositorio de monedas para ser utilizado en los métodos del servicio.
        public MonedaService(MonedaRepository monedaRepository)
        {
            _monedaRepository = monedaRepository; // Asigna el repositorio al campo privado.
        }

        // Método para obtener todas las monedas de manera asíncrona.
        public async Task<IEnumerable<Moneda>> ObtenerTodasAsync()
        {
            return await _monedaRepository.GetAllAsync(); // Llama al método GetAllAsync del repositorio para obtener todas las monedas.
        }

        // Método para obtener una moneda específica por su ID de manera asíncrona.
        public async Task<Moneda> ObtenerPorIdAsync(int id)
        {
            return await _monedaRepository.GetByIdAsync(id); // Llama al método GetByIdAsync del repositorio para obtener una moneda por su ID.
        }

        // Método para agregar una nueva moneda de manera asíncrona.
        public async Task AgregarAsync(Moneda moneda)
        {
            await _monedaRepository.AddAsync(moneda); // Llama al método AddAsync del repositorio para agregar una nueva moneda.
        }

        // Método para actualizar una moneda existente de manera asíncrona.
        public async Task ActualizarAsync(Moneda moneda)
        {
            await _monedaRepository.UpdateAsync(moneda); // Llama al método UpdateAsync del repositorio para actualizar una moneda.
        }

        // Método para eliminar una moneda por su ID de manera asíncrona.
        public async Task EliminarAsync(int id)
        {
            var moneda = await _monedaRepository.GetByIdAsync(id); // Obtiene la moneda por su ID.
            if (moneda != null) // Si la moneda existe.
            {
                await _monedaRepository.DeleteAsync(moneda); // Llama al método DeleteAsync del repositorio para eliminar la moneda.
            }
        }
    }
}
