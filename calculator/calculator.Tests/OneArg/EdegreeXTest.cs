using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class EdegreeXTests
    {
        [TestCase(0, 1)]
        [TestCase(0, 1)]
        [TestCase(0, 1)]

        public void EdegreeX(double firstValue, double expected)
        {
            var calculator = new EdegreeX();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}