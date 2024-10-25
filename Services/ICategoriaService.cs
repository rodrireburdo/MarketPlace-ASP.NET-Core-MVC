using AppCrud.Models;

namespace AppCrud.Services
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategorias();
    }
}
