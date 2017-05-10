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

        [TestMethod]
        public void TestMethod2AllUpper()
        {
            //Arange
            var sentenceTest = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Act
            var isPangram = Pangram.PangramSolution(sentenceTest);
            //Assert
            Assert.AreEqual(isPangram, "pangram");
        }

        [TestMethod]
        public void TestMethod3AllLower()
        {
            //Arange
            var sentenceTest = "abcdefghijklmnopqrstuvwxyz";
            //Act
            var isPangram = Pangram.PangramSolution(sentenceTest);
            //Assert
            Assert.AreEqual(isPangram, "pangram");
        }

        [TestMethod]
        public void TestMethodMixnMatch()
        {
            //Arange
            var sentenceTest = "abcdeFghijKlmnopqrstuvWXYZ";
            //Act
            var isPangram = Pangram.PangramSolution(sentenceTest);
            //Assert
            Assert.AreEqual(isPangram, "pangram");
        }
    }

}
