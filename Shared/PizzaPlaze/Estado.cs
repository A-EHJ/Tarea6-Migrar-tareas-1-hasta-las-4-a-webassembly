namespace Tarea6.Shared
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public CarritoDeCompra CarritoDeCompra { get; } = new CarritoDeCompra();
        public UI UI { get; set; } = new UI();
        public decimal PrecioTotal => CarritoDeCompra.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
