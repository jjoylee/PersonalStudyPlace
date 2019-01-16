using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    // Observer Pattern

    // 주제(subject) 객체에서 일부 데이터를 관리한다.
    // 주제의 데이터가 달라지면 observer한테 그 소식이 전해진다.
    // 데이터가 바뀌면 새로운 데이터 값이 observer들에게 전달된다.
    // observer객체들은 주제 객체에 등록되어 있으며 주제의 데이터가 바뀌면 갱신내용을 전달받는다.

    // 한 객체의 상태가 바뀌면 그 객체에 의존하는 다른 객체들한테 연락이 가고 자동으로 내용이 갱신되는 방식.
    // 일대다 의존성을 정의
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            // StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            // ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }
    }
}
