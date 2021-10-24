using Bogus;
using System;

namespace FakeDataGenerator.Services
{
    internal static class Gimme
    {
        static Gimme()
        {
            Randomizer.Seed = new Random(1024);
        }

        public static Randomizer Random = new Randomizer();
    }
}
