using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    // Facade Pattern
    // 어떤 서브시스템에 대한 간단한 인터페이스를 제공하기 위해 사용
    // 여러 세부단계들을 하나로 추상화
    // 어떤 서브시스템의 일련의 인터페이스에 대한 통합된 인터페이스를 제공한다.
    public class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector, Screen screen, TheaterLights lights, PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        // 모든 세부 동작들을 watchMovie라는 하나의 메서드로 캡슐화하여 간단하게 만듬.
        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            popper.on();
            popper.pop();

            lights.dim(10);

            screen.down();

            projector.on();
            projector.wideScreenMode();

            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
            amp.setVolume(5);

            dvd.on();
            dvd.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.off();

            lights.on();

            screen.up();

            projector.off();

            amp.off();

            dvd.stop();
            dvd.eject();
            dvd.off();
        }
    }
}
