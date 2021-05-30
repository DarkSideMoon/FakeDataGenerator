using System;

namespace FakeDataGenerator.Contracts.Bookshelf
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string ISBN { get; set; }

        public Person Author { get; set; }
    }
}
