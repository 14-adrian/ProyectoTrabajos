using System.ComponentModel.DataAnnotations;
namespace ProyectoTrabajos.Models
{
    public class ofertas
    {
        [Key]
        [Display(Name = "ID")]
        public int ofertaID { get; set; }
        [Display(Name = "Area")]
        public string? area { get; set; }
        [Display(Name = "Cargo")]
        public string? cargo { get; set; }
        [Display(Name = "Vacante")]
        public int? vacante { get; set; }
        [Display(Name = "Experiencia")]
        public string? experiencia { get; set; }
        [Display(Name = "Contratacion")]
        public string? contratacion { get; set; }
        [Display(Name = "Requisitos")]
        public string? requisitos { get; set; }
        [Display(Name = "Empresa ID")]
        public int empresaID { get; set; }
        [Display(Name = "Imagen")]
        public string? imagen { get; set; }
    }
}