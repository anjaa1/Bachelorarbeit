//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;
//using System;

//namespace MathNet.Numerics.Tests.StatisticsTests
//{
//    [TestClass]
//    public class ArrayStatisticsQuantileTests
//    {
//        private const double Delta = 1e-10; // Tolerance for floating-point comparisons

//        [TestMethod]
//        public void QuantileInplace_MedianOfOddLengthArray_ReturnsCorrectValue()
//        {
//            // Arrange
//            double[] data = { 1.0, 5.0, 3.0, 2.0, 4.0 };
//            // For median (tau = 0.5) with n = 5:
//            // h = (5 + 1/3) * 0.5 + 1/3 = 3
//            double expected = 3.0;
//            double tau = 0.5;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_FirstQuartile_ReturnsCorrectValue()
//        {
//            // Arrange
//            double[] data = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0 };
//            // For tau = 0.25 with n = 7:
//            // h = (7 + 1/3) * 0.25 + 1/3 = 2.167
//            // hf = 2
//            // Therefore: data[1] + 0.167 * (data[2] - data[1])
//            double expected = 2.1666666666666665;
//            double tau = 0.25;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_ThirdQuartile_ReturnsCorrectValue()
//        {
//            // Arrange
//            double[] data = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0 };
//            // For tau = 0.75 with n = 7:
//            // h = (7 + 1/3) * 0.75 + 1/3 = 5.833
//            // hf = 5
//            // Therefore: data[5] + 0.833 * (data[6] - data[5])
//            double expected = 5.833333333333333;
//            double tau = 0.75;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_TauZero_ReturnsMinimum()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 2.0 };
//            double expected = 1.0;
//            double tau = 0.0;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_TauOne_ReturnsMaximum()
//        {
//            // Arrange
//            double[] data = { 3.0, 1.0, 4.0, 2.0 };
//            double expected = 4.0;
//            double tau = 1.0;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_EmptyArray_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = new double[0];
//            double tau = 0.5;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void QuantileInplace_NegativeTau_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = { 1.0, 2.0, 3.0 };
//            double tau = -0.1;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void QuantileInplace_TauGreaterThanOne_ReturnsNaN()
//        {
//            // Arrange
//            double[] data = { 1.0, 2.0, 3.0 };
//            double tau = 1.1;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void QuantileInplace_SingleElementArray_ReturnsSingleElement()
//        {
//            // Arrange
//            double[] data = { 42.0 };
//            double expected = 42.0;
//            double tau = 0.5;

//            // Act
//            double result = ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(expected, result, Delta);
//        }

//        [TestMethod]
//        public void QuantileInplace_ModifiesOriginalArray()
//        {
//            // Arrange
//            double[] original = { 3.0, 1.0, 4.0, 2.0 };
//            double[] data = (double[])original.Clone();
//            double tau = 0.5;

//            // Act
//            ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            CollectionAssert.AreNotEqual(original, data);
//        }
//    }
//}
