//using MathNet.Numerics;
//using MathNet.Numerics.Random;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class CombinatoricsTests
//    {
//        [TestMethod]
//        public void CombinationsWithRepetition_TypicalScenario()
//        {
//            // Arrange
//            int n = 5;
//            int k = 3;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(35, result);
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_EdgeCaseZero()
//        {
//            // Arrange
//            int n = 0;
//            int k = 3;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(0, result);
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_EdgeCaseNegative()
//        {
//            // Arrange
//            int n = -5;
//            int k = 3;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(0, result);
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_EdgeCaseZeroBoth()
//        {
//            // Arrange
//            int n = 0;
//            int k = 0;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(1, result);
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_EdgeCaseInvalid()
//        {
//            // Arrange
//            int n = 5;
//            int k = -3;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.AreEqual(0, result);
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_EdgeCaseLargeInput()
//        {
//            // Arrange
//            int n = 100;
//            int k = 50;

//            // Act
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            // Assert
//            Assert.IsTrue(result > 0);
//        }
//    }
//}
