using System;
using System.Collections.Generic;
using System.Text;
using CSharp.VowelCount;
using NUnit.Framework;

namespace CSharpTest
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void GetVowelCountTest()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}
