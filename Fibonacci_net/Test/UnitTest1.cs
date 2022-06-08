using NUnit.Framework;
using Fibonacci;
namespace Test
{
    public class Tests
    {
        private int num = 10;
        private int[] serieFibonacci = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
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
            Assert.AreEqual(serieResponse.Length, this.num);
        }

        [Test]
        public void Test_the_size_of_the_list_is_different_from_order()
        {
            int[] serieResponse = serie.CalculateSeries(this.num);
            Assert.AreNotEqual(serieResponse.Length, this.num-1);
        }

        [Test]
        public void Test_check_the_fibonacci_sequence_is_correct()
        {
            int[] fib = serie.CalculateSeries(this.num);
            for (int i = 0; i < this.num; i++)
            {
                Assert.AreEqual(fib[i], serieFibonacci[i]);
            }
        }

        [Test]
        public void Test_check_the_fibonacci_length_is_correct()
        {
            int[] fib = serie.CalculateSeries(this.num);
            Assert.AreEqual(fib.Length, serieFibonacci.Length);
        }

        [Test]
        public void Test_check_the_fibonacci_sequence_correct()
        {
            int[] fib = serie.CalculateSeries(10);
            Assert.AreEqual(0, serieFibonacci[0]);
            Assert.AreEqual(1, serieFibonacci[1]);
        }
    }
}