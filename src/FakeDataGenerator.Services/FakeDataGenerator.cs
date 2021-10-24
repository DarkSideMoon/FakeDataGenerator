using FakeDataGenerator.Contracts.Vehicle;
using System.Collections.Generic;

namespace FakeDataGenerator.Services
{
    public static class FakeDataGenerator
    {
        public static List<Car> GenerateDefaultCars(int count) => FakeDataMapper.DeafultCar.Generate(count);

        public static List<Car> GenerateAdvancedCar(int count, string locale = "en")
        {
            var generator = FakeDataMapper.AdvancedCar;
            generator.Locale = locale;

            // Check configuration
            generator.AssertConfigurationIsValid();

            return generator.Generate(count);
        }
    }
}
