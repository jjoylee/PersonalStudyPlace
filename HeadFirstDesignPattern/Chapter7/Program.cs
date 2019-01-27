using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        // Adpater Pattern
        // 새로운 인터페이스를 기존의 인터페이스에 적응시켜주는 클래스
        // 혹은 기존의 인터페이스를 새로운 인터페이스에 적응시켜주는 클래스

        // 클라이언트에서 타겟 인터페이스(Duck)를 사용하여 메소드를 호출함으로써 어댑터에 요청 TurkeyAdpater
        // 어댑터에서는 어댑티 인터페이스를 사용하여 그 요청을 어댑티에 대한 메소드 호출로 변환 Turkey의 메소드 -> Duck의 메소드

        // 한 클래스의 인터페이스를 클라이언트에서 사용하고자 하는 다른 인터페이스로 변환
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey); // TurkeyAdapter implements Duck interface

            Console.WriteLine("The Turkey says..." );
            turkey.gobble();
            turkey.fly();

            Console.WriteLine();
            Console.WriteLine("The Duck syas...");
            testDuck(duck);

            Console.WriteLine();
            Console.WriteLine("The TurkeyAdapter syas...");
            testDuck(turkeyAdapter);

            // Facade Pattern

            Console.WriteLine();
            Console.WriteLine("------ Facade Pattern ------");
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, screen, lights, popper);
            homeTheater.watchMovie("Raiders of the Lost ark");
            homeTheater.endMovie();
        }

        private static void testDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
