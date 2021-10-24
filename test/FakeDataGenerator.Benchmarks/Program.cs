using Newtonsoft.Json;
using System;

namespace FakeDataGenerator.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bogus!");

            var cars = Services.FakeDataGenerator.GenerateAdvancedCar(3);
            var json = JsonConvert.SerializeObject(cars);

            Console.WriteLine(json);
            Console.ReadLine();

            // Add benchmarkdotnet 
        }
    }
}
