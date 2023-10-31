using System.ComponentModel.DataAnnotations;

namespace Tarea6.Shared
{
    public class Pizzas
    {
        public enum NivelPicante
        {
            Ninguno,
            Picante,
            MuyPicante
        }

        [Key]
        public int PizzaId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.01, 999999.99, ErrorMessage = "El precio debe estar entre 0.01 y 999999.99")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El Nivel de Picante es requerida")]
        public NivelPicante nivelPicante { get; set; }
    }
}
