using NUnit.Framework;
using CSharp.FindOddOccuringInt;
namespace CSharpTest
{
    [TestFixture]
    public class FindOddOccuringIntTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, FindOddOccuringInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}