using System.ComponentModel.DataAnnotations;

namespace ProyectoWEB.Models
{
    public class Prestamo
    {
        [Key] // Define la clave primaria
        public int Referencia { get; set; } // <--- PROPIEDAD QUE FALTABAdotnet add package Microsoft.EntityFrameworkCore.SqlServer

        [Required]
        public string Nombre { get; set; } // <--- PROPIEDAD QUE FALTABA

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "El monto debe ser mayor que 0")]
        public decimal Monto { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

       
        

    }
}
