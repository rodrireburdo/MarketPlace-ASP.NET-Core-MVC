using AppCrud.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCrud.Models
{
    public class Detalle_Pedido
    {
        [Key]
        public int DetallePedidoId { get; set; }

        [Required(ErrorMessage = "El campo pedidoId es obligatorio")]
        public int PedidoId { get; set; }
        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; } = null!;

        [Required(ErrorMessage = "El campo productoId es obligatorio")]
        public int ProductoId { get; set; }

        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; } = null!;

        [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public decimal Precio { get; set; }
    }
}