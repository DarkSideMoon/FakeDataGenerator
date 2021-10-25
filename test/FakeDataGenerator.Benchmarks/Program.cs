using Newtonsoft.Json;
using System;
using FakeDataGenerator.Services;

namespace FakeDataGenerator.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bogus!");

            var fakeGenerator = new FakeGenerator(3, "en");
            var cars = fakeGenerator.GenerateAdvancedCar();
            var json = JsonConvert.SerializeObject(cars);

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
