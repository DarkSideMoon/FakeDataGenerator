using Bogus;
using FakeDataGenerator.Contracts.Bookshelf;
using FakeDataGenerator.Contracts.Vehicle;

namespace FakeDataGenerator.Services
{
    public static class FakeDataMapper
    {
        public static Faker<Car> Car = new Faker<Car>()
            .RuleFor(x => x.Brand, f => f.Random.Enum<BrandEnum>())
            .RuleFor(x => x.Color, f => f.Random.Enum<ColorEnum>())
            .RuleFor(x => x.EngineVolume, f => f.Random.Double(0, 5))
            .RuleFor(x => x.IsAllWheelDrive, f => f.Random.Bool())
            .RuleFor(x => x.Price, f => f.Random.Double(1000, 10000))
            .RuleFor(x => x.TireBrand, f => f.Random.Enum<TireBrandEnum>())
            .RuleFor(x => x.TireDiameter, f => f.Random.Number())
            .RuleFor(x => x.TireProfile, f => f.Random.Double())
            .RuleFor(x => x.TireWidth, f => f.Random.Double())
            .RuleFor(x => x.VinCode, f => f.Random.Guid())
            .RuleFor(x => x.VehicleType, f => f.Random.Enum<VehicleTypeEnum>())
            .RuleFor(x => x.Year, f => f.Date.Past())
            .RuleFor(x => x.RegistrationNumber, f => f.Random.Guid().ToString())
            .RuleFor(x => x.TransmissionBrand, f => f.Company.CompanyName())
            .RuleFor(x => x.TransmissionNumber, f => f.Commerce.ProductName());

        public static Faker<Book> Book = new Faker<Book>()
            .RuleFor(x => x.Id, f => f.Random.Guid());
    }
}
