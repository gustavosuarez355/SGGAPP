using SggApp.DAL.Entidades; // Importa el espacio de nombres correspondiente

namespace SggApp.BLL.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetAllCategoriasAsync();
        Task<Categoria> GetCategoriaByIdAsync(int id);
        Task CreateCategoriaAsync(Categoria categoria);
        Task UpdateCategoriaAsync(Categoria categoria);
        Task DeleteCategoriaAsync(int id);
    }
}
