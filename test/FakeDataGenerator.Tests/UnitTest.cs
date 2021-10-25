using System.Collections.Generic;
using FakeDataGenerator.Services;
using NUnit.Framework;

namespace FakeDataGenerator.Tests
{
    public class Tests
    {
        private static IEnumerable<TestCaseData> Data
        {
            get
            {
                yield return new TestCaseData(100);
                yield return new TestCaseData(1000);
                yield return new TestCaseData(10000);
                yield return new TestCaseData(100000);
            }
        }

        [Test]
        public void TestAssertConfiguration_ShouldSuccess()
        {
            var generator = new FakeGenerator(1, "en");
            generator.AssertConfiguration();
        }

        [Test]
        [TestCaseSource(nameof(Data))]
        public void GenerateSimpleCar_ShouldSuccess(int count)
        {
            var generator = new FakeGenerator(count, "en");
            var data = generator.GenerateDefaultCars();

            Assert.NotNull(data);
            Assert.True(data.Count == count);
        }

        [Test]
        [TestCaseSource(nameof(Data))]
        public void GenerateAdvancedCar_ShouldSuccess(int count)
        {
            var generator = new FakeGenerator(count, "de");
            var data = generator.GenerateAdvancedCar();

            Assert.NotNull(data);
            Assert.True(data.Count == count);
        }
    }
}