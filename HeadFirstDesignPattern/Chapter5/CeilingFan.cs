using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    public class CeilingFan
    {
        string place;
        int speed;
        // const는 선언시 반드시 초기화
        // 내부에서 자동적으로 static이 됨
        // readonly는 초기화 시점이 다름 (생성자에서)
        // 별도로 static 선언을 해야 함.
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        
        public CeilingFan(string place)
        {
            this.place = place;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine(place + " ceiling fan is HIGH ");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine(place + " ceiling fan is MEDIUM ");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine(place + " ceiling fan is LOW ");
        }

        internal void on()
        {
            Console.WriteLine(place + " ceiling fan is on " );
        }

        internal void off()
        {
            speed = OFF;
            Console.WriteLine(place + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
