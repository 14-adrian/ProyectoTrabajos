using System.ComponentModel.DataAnnotations;

namespace TuProyecto.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo Usuario es requerido.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es requerido.")]
        public string Contrasena { get; set; }
    }
}
