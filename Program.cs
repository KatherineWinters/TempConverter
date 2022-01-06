using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(50);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(10);

            Console.WriteLine($"Celsius after converting from fahrenheit is: {celsius}");
            Console.WriteLine($"Fahrenheit after converting from celsius is {fahrenheit}");

        }
    }
}
