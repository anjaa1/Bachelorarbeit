//using System;
//using System.Collections.Generic;
//using MathNet.Numerics;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SeriesTests
//    {
//        [TestMethod]
//        public void Evaluate_EmptyInput_ReturnsZero()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double>();

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(0.0, result, "Expected sum of an empty series to be 0.");
//        }

//        [TestMethod]
//        public void Evaluate_SingleElement_ReturnsElement()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { 42.0 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(42.0, result, "Expected sum of a single-element series to equal the element.");
//        }

//        [TestMethod]
//        public void Evaluate_MultipleElements_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { 1.0, 2.0, 3.0, 4.0 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(10.0, result, "Expected sum of the series to be 10.");
//        }

//        [TestMethod]
//        public void Evaluate_NegativeAndPositiveElements_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { -5.0, 10.0, -3.0, 8.0 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(10.0, result, "Expected sum to handle both positive and negative numbers correctly.");
//        }

//        [TestMethod]
//        public void Evaluate_LargeNumbers_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { 1e16, -1e16, 3.0 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(3.0, result, "Expected sum to be numerically stable for large numbers.");
//        }

//        [TestMethod]
//        public void Evaluate_SmallNumbers_ReturnsCorrectSum()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { 1e-16, 2e-16, 3e-16 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.IsTrue(Math.Abs(result - 6e-16) < 1e-18, "Expected sum to handle small numbers with precision.");
//        }

//        [TestMethod]
//        public void Evaluate_AlternatingSeries_ConvergesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> summands = new List<double> { 1.0, -0.5, 0.25, -0.125, 0.0625 };

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.IsTrue(Math.Abs(result - 0.6875) < 1e-6, "Expected sum to converge correctly for an alternating series.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void Evaluate_NullInput_ThrowsArgumentNullException()
//        {
//            // Act
//            Series.Evaluate((IEnumerable<double>)null);
//        }

//        [TestMethod]
//        public void Evaluate_LargeSeries_PerformanceAndCorrectness()
//        {
//            // Arrange
//            var summands = new List<double>();
//            for (int i = 0; i < 1_000_000; i++)
//            {
//                summands.Add(1.0 / (i + 1));
//            }

//            // Act
//            var result = Series.Evaluate(summands);

//            // Assert
//            Assert.IsTrue(result > 10.0 && result < 15.0, "Expected result to be within the approximate range of the harmonic series sum.");
//        }
//    }
//}
