using System.ComponentModel.DataAnnotations;

namespace ProyectoTrabajos.Models
{
    public class testimonios
    {
        [Key]
        public int testimoniosID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }
    }
}
