using System.ComponentModel.DataAnnotations;

namespace Tarea6.Shared
{
    public class CarritoDeCompra
    {
        [Key]
        public int CarritoId { get; set; }
        [Required]
        public Cliente Cliente { get; set; } = new Cliente();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool EstaPago { get; set; }
        public void AgregarALasOrdenes(int pizzaId) => Ordenes.Add(pizzaId);
        public void RemoverLaPosicion(int pos) => Ordenes.RemoveAt(pos);
    }
}