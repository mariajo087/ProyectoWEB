namespace ProyectoWEB.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }  // ✅ Agregar esta propiedad
        public string Referencia { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}