using AppCrud.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace AppCrud.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; } = null!;

        [Required(ErrorMessage = "El campo fecha es requerido")]
        public DataSetDateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo estado es requerido")]
        [StringLength(50)]
        public string Estado { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public int DireccionIdSeleccionada { get; set; }

        [ForeignKey("DireccionIdSeleccionada")]
        public Direccion Direccion { get; set; } = null!;

        [Required(ErrorMessage = "El campo total es requerido")]
        public decimal Total { get; set; }

        public ICollection<Detalle_Pedido> DetallesPedido { get; set; } = null!;

    }
}