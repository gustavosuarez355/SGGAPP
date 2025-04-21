using SggApp.DAL.Entidades; // Importa el espacio de nombres correspondiente

namespace SggApp.BLL.Interfaces
{
    public interface IMonedaService
    {
        Task<IEnumerable<Moneda>> GetAllMonedasAsync();
        Task<Moneda> GetMonedaByIdAsync(int id);
        Task CreateMonedaAsync(Moneda moneda);
        Task UpdateMonedaAsync(Moneda moneda);
        Task DeleteMonedaAsync(int id);
    }
}
