using SggApp.DAL.Entidades; // Importa el espacio de nombres correspondiente

namespace SggApp.BLL.Interfaces
{
    public interface IGastoService
    {
        Task<IEnumerable<Gasto>> GetAllGastosAsync();
        Task<Gasto> GetGastoByIdAsync(int id);
        Task CreateGastoAsync(Gasto gasto);
        Task UpdateGastoAsync(Gasto gasto);
        Task DeleteGastoAsync(int id);
    }
}
