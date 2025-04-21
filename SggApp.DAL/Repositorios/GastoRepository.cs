using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Contextos;
using SggApp.DAL.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SggApp.DAL.Repositorios
{
    // Implementación del repositorio específico para la entidad Gasto
    public class GastoRepository : GenericRepository<Gasto>, IGastoRepository
    {
        private readonly SggAppDbContext _context;

        // Constructor que recibe el contexto y lo pasa al repositorio genérico
        public GastoRepository(SggAppDbContext context) : base(context)
        {
            _context = context;
        }

        // Método para obtener los gastos asociados a un usuario específico
        public async Task<IEnumerable<Gasto>> ObtenerGastosPorUsuarioAsync(int usuarioId)
        {
            // Usamos LINQ para filtrar los gastos por el ID del usuario
            return await _context.Gastos
                                 .Where(g => g.UsuarioId == usuarioId)
                                 .Include(g => g.Usuario)  // Incluye la relación con Usuario si es necesario
                                 .Include(g => g.Categoria) // Incluye la relación con Categoria si es necesario
                                 .Include(g => g.Moneda)    // Incluye la relación con Moneda si es necesario
                                 .ToListAsync(); // Convierte el resultado en una lista asincrónicamente
        }
    }
}
