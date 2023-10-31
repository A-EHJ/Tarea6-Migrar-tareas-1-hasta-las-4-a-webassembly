namespace Tarea6.Shared
{
    public class Menu
    {
              
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Agregar(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.PizzaId == id);
    }
}