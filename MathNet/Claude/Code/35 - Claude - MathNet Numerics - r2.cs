//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;
//using System;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class CombinatoricsTests
//    {
//        [TestMethod]
//        public void CombinationsWithRepetition_ValidInputs_ReturnsExpectedResult()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(1, Combinatorics.CombinationsWithRepetition(1, 1), "Selecting 1 from 1");
//            Assert.AreEqual(3, Combinatorics.CombinationsWithRepetition(2, 2), "Selecting 2 from 2");
//            Assert.AreEqual(6, Combinatorics.CombinationsWithRepetition(3, 2), "Selecting 2 from 3");
//            Assert.AreEqual(10, Combinatorics.CombinationsWithRepetition(4, 2), "Selecting 2 from 4");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_LargeNumbers_ReturnsExpectedResult()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(715, Combinatorics.CombinationsWithRepetition(10, 4), "Selecting 4 from 10");
//            Assert.AreEqual(1365, Combinatorics.CombinationsWithRepetition(12, 4), "Selecting 4 from 12");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_ZeroK_ReturnsOne()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(1, Combinatorics.CombinationsWithRepetition(5, 0), "Selecting 0 from 5");
//            Assert.AreEqual(1, Combinatorics.CombinationsWithRepetition(10, 0), "Selecting 0 from 10");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_BothZero_ReturnsOne()
//        {
//            // Arrange & Act
//            double result = Combinatorics.CombinationsWithRepetition(0, 0);

//            // Assert
//            Assert.AreEqual(1, result, "Both n and k are 0");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_NegativeN_ReturnsZero()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(-1, 5), "Negative n value");
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(-10, 3), "Negative n value");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_NegativeK_ReturnsZero()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(5, -1), "Negative k value");
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(10, -3), "Negative k value");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_ZeroNPositiveK_ReturnsZero()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(0, 1), "n=0, k=1");
//            Assert.AreEqual(0, Combinatorics.CombinationsWithRepetition(0, 5), "n=0, k=5");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_KGreaterThanN_ReturnsValidResult()
//        {
//            // Arrange & Act & Assert
//            Assert.AreEqual(4, Combinatorics.CombinationsWithRepetition(2, 3), "Selecting 3 from 2");
//            Assert.AreEqual(21, Combinatorics.CombinationsWithRepetition(3, 5), "Selecting 5 from 3");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_ResultIsWholeNumber()
//        {
//            // Arrange
//            int n = 5;
//            int k = 3;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(Math.Floor(result), result,
//                "Result should be a whole number");
//            Assert.AreEqual(0, result % 1,
//                "Result should not have decimal places");
//        }
//    }
//}
