using System;

namespace Chapter4
{
    internal class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");
            } else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}