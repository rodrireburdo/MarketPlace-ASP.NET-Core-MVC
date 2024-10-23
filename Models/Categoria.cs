using System.ComponentModel.DataAnnotations;

namespace AppCrud.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Productos = new List<Producto>(); // inicio una lista vacia para la propiedad producto y que no sea null
        }

        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La descripción es requerido")]
        [StringLength(1000)]
        public string Descripcion { get; set; } = null!;

        public ICollection<Producto> Productos { get; set; }
    }
}