//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SeriesTests
//    {
//        [TestMethod]
//        public void Evaluate_EmptySequence_ReturnsZero()
//        {
//            // Arrange
//            IEnumerable<double> emptySequence = Array.Empty<double>();

//            // Act
//            double result = Series.Evaluate(emptySequence);

//            // Assert
//            Assert.AreEqual(0.0, result);
//        }

//        [TestMethod]
//        public void Evaluate_SingleElement_ReturnsThatElement()
//        {
//            // Arrange
//            IEnumerable<double> singleElement = new double[] { 5.0 };

//            // Act
//            double result = Series.Evaluate(singleElement);

//            // Assert
//            Assert.AreEqual(5.0, result);
//        }

//        [TestMethod]
//        public void Evaluate_SimpleSequence_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> sequence = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            double expectedSum = 15.0;

//            // Act
//            double result = Series.Evaluate(sequence);

//            // Assert
//            Assert.AreEqual(expectedSum, result, 1e-10);
//        }

//        [TestMethod]
//        public void Evaluate_SequenceWithNegativeNumbers_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> sequence = new double[] { -1.0, 2.0, -3.0, 4.0, -5.0 };
//            double expectedSum = -3.0;

//            // Act
//            double result = Series.Evaluate(sequence);

//            // Assert
//            Assert.AreEqual(expectedSum, result, 1e-10);
//        }

//        [TestMethod]
//        public void Evaluate_LargeNumbers_HandlesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> sequence = new double[] { 1e15, 1e14, 1e13 };
//            double expectedSum = 1.11e15;

//            // Act
//            double result = Series.Evaluate(sequence);

//            // Assert
//            Assert.AreEqual(expectedSum, result, 1e5);
//        }

//        [TestMethod]
//        public void Evaluate_SmallNumbers_HandlesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> sequence = new double[] { 1e-15, 1e-14, 1e-13 };
//            double expectedSum = 1.11e-13;

//            // Act
//            double result = Series.Evaluate(sequence);

//            // Assert
//            Assert.AreEqual(expectedSum, result, 1e-25);
//        }

//        [TestMethod]
//        public void Evaluate_AlternatingSequence_HandlesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> sequence = new double[] { 1.0, -1.0, 1.0, -1.0, 1.0 };
//            double expectedSum = 1.0;

//            // Act
//            double result = Series.Evaluate(sequence);

//            // Assert
//            Assert.AreEqual(expectedSum, result, 1e-10);
//        }

//        [TestMethod]
//        public void Evaluate_InfiniteSequence_StopsAutomatically()
//        {
//            // Arrange
//            IEnumerable<double> infiniteSequence = GenerateGeometricSequence(2.0, 0.5);

//            // Act
//            double result = Series.Evaluate(infiniteSequence);

//            // Assert
//            Assert.AreEqual(4.0, result, 1e-10);
//        }

//        [TestMethod]
//        public void Evaluate_NullSequence_ThrowsArgumentNullException()
//        {
//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => Series.Evaluate((IEnumerable<double>)null));
//        }

//        // Helper method to generate an infinite geometric sequence
//        private static IEnumerable<double> GenerateGeometricSequence(double firstTerm, double ratio)
//        {
//            double currentTerm = firstTerm;
//            while (true)
//            {
//                yield return currentTerm;
//                currentTerm *= ratio;
//            }
//        }
//    }
//}
