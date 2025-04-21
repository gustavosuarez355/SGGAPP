using SggApp.DAL.Entidades; // Importa la entidad Gasto
using System.Threading.Tasks; // Para métodos asincrónicos
using System.Collections.Generic; // Para IEnumerable

namespace SggApp.DAL.Repositorios
{
    // Interfaz para operaciones específicas de la entidad Gasto
    public interface IGastoRepository : IGenericRepository<Gasto>
    {
        // Método para obtener los gastos de un usuario específico
        // Puedes agregar otros filtros adicionales como fecha, monto, etc. si es necesario
        Task<IEnumerable<Gasto>> ObtenerGastosPorUsuarioAsync(int usuarioId);
    }
}
