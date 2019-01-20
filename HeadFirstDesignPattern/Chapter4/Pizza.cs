using System;
using System.Collections;

namespace Chapter4
{
    public abstract class Pizza
    {
        //protected string name;
        //protected string dough;
        //protected string sauce;
        //protected ArrayList toppings = new ArrayList();

        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public abstract void prepare();

        //internal void prepare()
        //{
        //    Console.WriteLine("Preparing " + name);
        //    Console.WriteLine("Tossing Dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings : ");
        //    foreach(string topping in toppings)
        //    {
        //        Console.WriteLine(" " + topping);
        //    }
        //}

        internal void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}