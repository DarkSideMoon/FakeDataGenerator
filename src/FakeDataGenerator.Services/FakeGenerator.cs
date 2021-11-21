using FakeDataGenerator.Contracts.Vehicle;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace FakeDataGenerator.Services
{
    [MemoryDiagnoser]
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class FakeGenerator
    {
        [Params(100000, 500000, 1000000)]
        public int Count { get; set; }

        [Params("en")]
        public string Locale { get; set; }

        public FakeGenerator()
        {
        }

        public FakeGenerator(string locale)
        {
            Locale = locale;
        }

        public FakeGenerator(int count, string locale)
        {
            Count = count;
            Locale = locale;
        }

        public List<Car> GenerateDefaultCars() => FakeDataMapper.DeafultCar.Generate(Count);

        [Benchmark]
        public List<Car> GenerateAdvancedCar()
        {
            var generator = FakeDataMapper.AdvancedCar;
            generator.Locale = Locale;
            return generator.Generate(Count);
        }

        public void AssertConfiguration()
        {
            var generator = FakeDataMapper.AdvancedCar;
            // Check configuration
            generator.AssertConfigurationIsValid();
        }
    }
}
