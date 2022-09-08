using System.ComponentModel.DataAnnotations;
using ControlIDMvc.Dtos.Tarjeta;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ControlIDMvc.Dtos
{
    [Index(nameof(Ci), IsUnique = true)]
    public class PersonaCreateDto
    {
        [Required(ErrorMessage = "CI requerido")]
        public string Ci { get; set; }
        [Required(ErrorMessage = "EL Nombre requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "EL Apellido requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "EL Fecha Nacimiento requerido")]
        public DateTime Fecha_nac { get; set; }
        [Required(ErrorMessage = "EL Email requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "EL Celular requerido")]
        public string Celular { get; set; }
        public string Dirrecion { get; set; }
        public string Observaciones { get; set; }
        [Required(ErrorMessage = "EL Usuario requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "EL Contraseña requerido")]
        public string Contraseña { get; set; }
        public string Sincronizacion { get; set; }
        public string ControlId { get; set; }
        [JsonProperty(PropertyName = "cards")]
        public List<string> Area { get; set; }
        public List<string> Codigo { get; set; }
    }
}