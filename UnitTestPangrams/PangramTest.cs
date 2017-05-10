using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PangramsTesting;

namespace UnitTestPangrams
{
    [TestClass]
    public class PangramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            var sentenceTest = "We promptly judged antique ivory buckles for the next prize";
            //Act
            var isPangram = Pangram.PangramSolution(sentenceTest);
            //Assert
            Assert.AreEqual(isPangram, "pangram");
        }
    }
}
