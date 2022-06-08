using NUnit.Framework;
using Fibonacci;
namespace Test
{
    public class Tests
    {
        private int num = 10;
        private int[] serieFibonacci = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        Serie serie;

        [SetUp]
        public void Setup()
        {
            serie = new Serie();
        }

        [Test]
        public void Test_creation_method()
        {
            int[] serieResponse = serie.CalculateSeries(this.num);
            Assert.Equals(serieResponse.Length, this.num);
        }
    }
}