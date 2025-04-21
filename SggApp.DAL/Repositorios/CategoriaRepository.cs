using Microsoft.EntityFrameworkCore; // Para usar Entity Framework Core
using SggApp.DAL.Contextos; // Para acceder al DbContext
using SggApp.DAL.Entidades; // Para usar la entidad Categoria
using System.Collections.Generic; // Para IEnumerable
using System.Threading.Tasks; // Para Task
using System.Linq; // Para usar LINQ

namespace SggApp.DAL.Repositorios
{
    // Implementación del repositorio específico para la entidad Categoria
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        // Campo privado para acceder al DbContext
        private readonly SggAppDbContext _context;

        // Constructor que recibe el contexto y lo pasa al repositorio genérico
        public CategoriaRepository(SggAppDbContext context) : base(context)
        {
            _context = context;
        }

        // Método para obtener todas las categorías activas
        public async Task<IEnumerable<Categoria>> ObtenerCategoriasActivasAsync()
        {
            // Aquí, si hay un campo 'Activo' en la entidad Categoria, se puede filtrar
            return await _context.Categorias.Where(c => c.Activo == true)  // Filtra las categorías activas
                                           .ToListAsync();  // Convierte el resultado en una lista asincrónicamente
        }
    }
}
