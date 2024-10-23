using AppCrud.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCrud.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }

        [Required(ErrorMessage = "El campo dirección es requerido")]
        [StringLength(50)]
        public string Address { get; set; } = null!; //no lepuedo poner dirrecion porque me genra conflicto con el nombre de la clase

        [Required]
        [StringLength(30)]
        public string Ciudad { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string Provincia { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string CodigoPostal { get; set; } = null!;

        [Required(ErrorMessage = "El campo UsuarioId es requerido")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; } = null!;
    }
}