using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_3_konvertera_temperaturer.Model
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC){

            int fahrenheit;
            fahrenheit = degreesC * (9/5) + 32;
            return fahrenheit;
        }

        public static int FahrenheitToCelsius(int degreesF)
        {
            int celsius;
            celsius = (degreesF - 32) * 5 / 9;
            return celsius;
        }
    }
}