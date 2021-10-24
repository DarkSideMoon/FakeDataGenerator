using Bogus;
using FakeDataGenerator.Contracts.Vehicle;
using System;

namespace FakeDataGenerator.Services
{
    public static class FakeDataMapper
    {
        // Default example of mapping rules for Car model
        public static Faker<Car> DeafultCar = new Faker<Car>()
            .RuleFor(x => x.Brand, f => f.PickRandom<BrandEnum>())
            .RuleFor(x => x.Color, f => f.Random.Enum<ColorEnum>())
            .RuleFor(x => x.EngineVolume, f => f.Random.Double(0, 5))
            .RuleFor(x => x.IsAllWheelDrive, f => f.Random.Bool())
            .RuleFor(x => x.Price, f => f.Random.Double(1000, 10000))
            .RuleFor(x => x.VinCode, f => f.Vehicle.Vin())
            .RuleFor(x => x.VehicleType, f => f.Random.Enum<VehicleTypeEnum>())
            .RuleFor(x => x.Year, f => f.Date.Past())
            .RuleFor(x => x.RegistrationNumber, f => f.Random.Guid().ToString());

        public static Faker<Car> AdvancedCar = new Faker<Car>()
            // Ensure all properties have rules. By default, StrictMode is false
            // Example with StrictMode = true 
            .StrictMode(true)
            .RuleFor(x => x.VinCode, f => f.Vehicle.Vin())
            .RuleFor(x => x.RegistrationNumber, f => f.Random.Guid().ToString())
            // Method to pick random data of your class 
            .RuleFor(x => x.Brand, f => f.PickRandom<BrandEnum>())
            .RuleFor(x => x.Color, f => f.Random.Enum<ColorEnum>())
            .RuleFor(x => x.EngineVolume, f => f.Random.Double(0, 5))
            .RuleFor(x => x.IsAllWheelDrive, f => f.Random.Bool())
            .RuleFor(x => x.Price, f => f.Random.Double(1000, 10000))
            // Method to pick random data of your class 
            .RuleFor(x => x.VehicleType, f => f.Random.Enum<VehicleTypeEnum>())
            .RuleFor(x => x.Year, f => f.Date.Past())
            .RuleFor(x => x.Tire, f => new Tire
            {
                Brand = f.PickRandom<TireBrandEnum>(),
                Diameter = f.Random.Number(10, 100)
            })
            .RuleFor(x => x.Transmission, f => new Transmission 
            {
                Brand = f.Company.CompanyName(),
                Number = f.Commerce.ProductName()
            })
            // Optional: After all rules are applied finish with the following action
            // Sometimes can be logging or other helpful logic
            .FinishWith((faker, car) => 
            {
                Console.WriteLine($"New car {car.VinCode} was generated successfully");
            });
    }
}
