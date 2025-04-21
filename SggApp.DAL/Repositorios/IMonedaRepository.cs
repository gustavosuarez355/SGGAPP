using SggApp.DAL.Entidades; // Para usar la entidad Moneda
using SggApp.DAL.Repositorios.Interfaces; // Para seguir la estructura de repositorios

namespace SggApp.DAL.Repositorios.Interfaces
{
    // Interfaz específica para las operaciones con la entidad Moneda
    public interface IMonedaRepository : IGenericRepository<Moneda>
    {
        // Si se necesitan métodos adicionales específicos para Moneda, se pueden agregar aquí
    }
}
