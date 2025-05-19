using System.ComponentModel.DataAnnotations;

namespace ProyectoWEB.Models
{


    public class Contacto
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Asunto { get; set; }

        [Required]
        public string Mensaje { get; set; }

    }
}