using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long result = Summator.Sum(new int[] { 5, 7 });
            Assert.That(result==12);
        }

        [Test]
        public void Test_Sum_OnepositiveNumber()
        {
            long result = Summator.Sum(new int[] { 5 });
            Assert.That(result==5);
        }

        [Test]
        public void Test_Sum_TwoNegativesNumber()
        {
            long result = Summator.Sum(new int[] { -5,-7 });
            Assert.That(result == -12);
        }

        [Test]
        public void Test_Sum_EmptyArea()
        {
            long result = Summator.Sum(new int[] {  });
            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long result = Summator.Sum(new int[] {2000000000,2000000000,2000000000});
            Assert.That(result == 6000000000);
        }

        [Test]
        public void Test_AverageTwoPositiveNumbers()
        {
            decimal result = Summator.Average(new decimal[] { 5, 6 });
            Assert.That(result == 5.5M);
        }
    }

}