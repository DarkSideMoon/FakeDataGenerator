using BenchmarkDotNet.Running;
using FakeDataGenerator.Services;

namespace FakeDataGenerator.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<FakeGenerator>();
        }
    }
}
