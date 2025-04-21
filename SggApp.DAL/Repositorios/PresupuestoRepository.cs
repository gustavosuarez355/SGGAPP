using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Contextos;
using SggApp.DAL.Entidades;

namespace SggApp.DAL.Repositorios
{
    // Implementación del repositorio de la entidad Presupuesto
    public class PresupuestoRepository : GenericRepository<Presupuesto>, IPresupuestoRepository
    {
        // Constructor que recibe el contexto de la base de datos
        public PresupuestoRepository(SggAppDbContext context) : base(context) { }

        // Métodos adicionales específicos para Presupuesto, si es necesario
    }
}
