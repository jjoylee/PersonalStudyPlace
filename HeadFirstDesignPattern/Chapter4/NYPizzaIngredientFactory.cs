using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroon(), new RedPepper() };
            return veggies;
        }
    }
}
