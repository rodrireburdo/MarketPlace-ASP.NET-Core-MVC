using AppCrud.Models;
using AppCrud.Models.ViewModels;

namespace AppCrud.Services
{
    public interface IProductoService
    { 
        Producto GetProducto(int id);

        Task<List<Producto>> GetProductosDestacados();

        Task<ProductosPaginadosViewModel> GetProductosPaginados(int? categoria, string? busqueda, int pagina, int productosPorPagina);
    }
}
