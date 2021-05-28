using Bogus;
using FakeDataGenerator.Contracts.Bookshelf;
using FakeDataGenerator.Contracts.Vehicle;

namespace FakeDataGenerator.Services
{
    public static class FakeDataMapper
    {
        public static Faker<Car> Car = new Faker<Car>()
            .RuleFor(x => x.Brand, f => f.Random.Enum<BrandEnum>());

        public static Faker<Book> Book = new Faker<Book>()
            .RuleFor(x => x.Id, f => f.Random.Guid());
    }
}
