using System.ComponentModel.DataAnnotations;

namespace AppCrud.Models
{
    public class Rol
    {
        // Como la base de datos se va a hacer automatica, usamos los dataAnnotations
        [Key]
        public int RolId { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
    }
}