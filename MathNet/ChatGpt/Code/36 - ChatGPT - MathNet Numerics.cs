//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;
//using System;

//namespace MathNet.Numerics.Statistics.Tests
//{
//    [TestClass]
//    public class ArrayStatisticsTests
//    {
//        [TestMethod]
//        public void QuantileInplace_ValidInput_TauIsMedian_ReturnsMedian()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 1.5, 2.0 };
//            double tau = 0.5; // Median

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(2.0, result, 1e-6, "Median quantile calculation failed.");
//        }

//        [TestMethod]
//        public void QuantileInplace_ValidInput_TauIsZero_ReturnsMinimum()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 1.5, 2.0 };
//            double tau = 0.0; // Minimum

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(1.0, result, 1e-6, "Minimum quantile calculation failed.");
//        }

//        [TestMethod]
//        public void QuantileInplace_ValidInput_TauIsOne_ReturnsMaximum()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 1.5, 2.0 };
//            double tau = 1.0; // Maximum

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(4.0, result, 1e-6, "Maximum quantile calculation failed.");
//        }

//        [TestMethod]
//        public void QuantileInplace_EmptyArray_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = { };
//            double tau = 0.5; // Any tau

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "Quantile calculation for empty array should return NaN.");
//        }

//        [TestMethod]
//        public void QuantileInplace_InvalidTauNegative_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 1.5, 2.0 };
//            double tau = -0.1; // Invalid tau

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "Quantile calculation for tau < 0 should return NaN.");
//        }

//        [TestMethod]
//        public void QuantileInplace_InvalidTauGreaterThanOne_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 1.5, 2.0 };
//            double tau = 1.1; // Invalid tau

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "Quantile calculation for tau > 1 should return NaN.");
//        }

//        [TestMethod]
//        public void QuantileInplace_SingleElementArray_ReturnsElement()
//        {
//            // Arrange
//            double[] data = { 42.0 };
//            double tau = 0.5; // Median (only one element)

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(42.0, result, 1e-6, "Quantile calculation for single-element array failed.");
//        }
//    }
//}
