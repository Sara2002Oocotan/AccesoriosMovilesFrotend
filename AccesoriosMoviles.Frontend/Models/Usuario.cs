using System.ComponentModel.DataAnnotations;

namespace AccesoriosMoviles.Frontend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Rol es obligatorio")]
        public int IdRol { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
    }
}
