using strukturos;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingTaxCalculator()
        {
            decimal income =10000;
            decimal expecteResult = 500;
            decimal actualResult = Program.CalculateTax(income);
            Assert.Pass();
        }
    }
}