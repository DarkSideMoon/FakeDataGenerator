using System.Collections.Generic;

namespace FakeDataGenerator.Contracts.Bookshelf
{
    public class Member
    {
        public Person User { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
