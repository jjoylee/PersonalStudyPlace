using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.simulate(duckFactory);
        }

        private void simulate(AbstractDuckFactory duckFactory)
        {
            Quackable redheadDuck = duckFactory.createRedheadDuck();
            Quackable duckCall = duckFactory.createDuckCall();
            Quackable rubberDuck = duckFactory.createRubberDuck();
            Quackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator");

            Flock flockOfDucks = new Flock();

            flockOfDucks.add(redheadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseDuck);

            Flock flockOfMallards = new Flock();

            Quackable mallardOne = duckFactory.createMallardDuck();
            Quackable mallardTwo = duckFactory.createMallardDuck();
            Quackable mallardThree = duckFactory.createMallardDuck();
            Quackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallards.add(mallardOne);
            flockOfMallards.add(mallardTwo);
            flockOfMallards.add(mallardThree);
            flockOfMallards.add(mallardFour);

            flockOfDucks.add(flockOfMallards);
            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);
            simulate(flockOfDucks);
            //simulate(mallardDuck);
            //simulate(redheadDuck);
            //simulate(duckCall);
            //simulate(rubberDuck);
            //simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " + QuackCounter.getQuacks() + " times ");
            simulate(flockOfMallards);
        }

        private void simulate(Quackable duck)
        {
            duck.quack();
        }
    }
}
