using AppCrud.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCrud.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo Codigo es requerido")]
        [StringLength(50)]
        public string Codigo { get; set; } = null!;


        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(255)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El campo modelo es requerido")]
        [StringLength(255)]
        public string Modelo { get; set; } = null!;

        [Required(ErrorMessage = "El campo descripción es requerido")]
        [StringLength(1000)]
        public string Descripcion { get; set; } = null!;

        [Required(ErrorMessage = "El campo precio es requerido")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El campo imagen es requerido")]
        [StringLength(255)]
        public string Imagen { get; set; } = null!;

        [Required(ErrorMessage = "El campo categoria es requerido")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; } = null!;

        [Required(ErrorMessage = "El campo stock es requerido")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "El campo marca es requerido")]
        [StringLength(100)]
        public string Marca { get; set; } = null!;

        [Required(ErrorMessage = "El campo activo es requerido")]
        public bool Activo { get; set; }

        public ICollection<Detalle_Pedido> DetallesPedido { get; set; } = null!;
    }
}