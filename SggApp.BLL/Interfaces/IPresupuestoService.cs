using SggApp.DAL.Entidades; // Importa el espacio de nombres correspondiente

namespace SggApp.BLL.Interfaces
{
    public interface IPresupuestoService
    {
        Task<IEnumerable<Presupuesto>> GetAllPresupuestosAsync();
        Task<Presupuesto> GetPresupuestoByIdAsync(int id);
        Task CreatePresupuestoAsync(Presupuesto presupuesto);
        Task UpdatePresupuestoAsync(Presupuesto presupuesto);
        Task DeletePresupuestoAsync(int id);
    }
}
