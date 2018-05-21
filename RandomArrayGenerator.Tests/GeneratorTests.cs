using System.Linq;

namespace RandomArrayGenerator.Tests
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class GeneratorTests
    {
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void RandomFirstGeneratorTest(int n)
        {
            FirstGenerator generator = new FirstGenerator();
            var result = generator.GenerateArray(n);
            Assert.IsTrue(Math.Abs(result.Sum() - 1) < 0.000001);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        public void RandomSecondGeneratorTest(int n)
        {
            SecondGenerator generator = new SecondGenerator();
            var result = generator.GenerateArray(n);
            Assert.IsTrue(Math.Abs(result.Sum() - 1) < 0.000001);
        }

        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(1)]
        public void GeneratorExeptionTest(int n)
        {
            SecondGenerator secondGenerator = new SecondGenerator();
            FirstGenerator firstGenerator = new FirstGenerator();
            Assert.Throws<ArgumentException>(() => firstGenerator.GenerateArray(n));
            Assert.Throws<ArgumentException>(() => secondGenerator.GenerateArray(n));
        }
    }
}
