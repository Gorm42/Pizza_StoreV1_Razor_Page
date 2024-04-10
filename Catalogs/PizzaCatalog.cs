using Pizza_StoreV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV1.PizzaCatalogs
{
    public class PizzaCatalog
    {
        private Dictionary<int, Pizza> pizzadictionary { get; }
        public PizzaCatalog()
        {
            pizzadictionary = new Dictionary<int, Pizza>();
            pizzadictionary.Add(1, new Pizza() { Id = 1, Name = "Cheese_pizza", Description = " Made of cheese", Price = 98 , ImageName= "Cheese_pizza.jfif" });
            pizzadictionary.Add(2, new Pizza() { Id = 2, Name = "Bufalla_pizza", Description = " Made of bufalla", Price = 59, ImageName = "Bufalla_pizza.jfif" });
            pizzadictionary.Add(3, new Pizza() { Id = 3, Name = "Chicken_pizza", Description = " Made of chicken", Price = 120, ImageName = "Chicken_pizza.jfif" });
            pizzadictionary.Add(4, new Pizza() { Id = 4, Name = "Mozzarella_pizza", Description = " Made of mozzarella", Price = 77, ImageName = "Mozzarella_pizza.jfif" });
            pizzadictionary.Add(5, new Pizza() { Id = 5, Name = "Vegetable_pizza", Description = " Made from vegetarians", Price = 88, ImageName = "Vegetable_pizza.jfif" });
        }

        public Dictionary<int,Pizza> AllPizzas()
        {
            foreach(Pizza pizza in pizzadictionary.Values)
            {
                Console.WriteLine(pizza);
            }

            // not implemented yet. We return an empty dictionary to avoid compile error
            return new Dictionary<int,Pizza>();
        }
        public void OnGet()
        {

        }
    }
}
