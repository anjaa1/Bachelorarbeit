//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ArrayStatisticsTests
//    {
//        [TestMethod]
//        public void QuantileInplace_TypicalCase()
//        {
//            // Arrange
//            double[] data = { 1, 2, 3, 4, 5 };
//            double tau = 0.5;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(3, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_TauIsZero()
//        {
//            // Arrange
//            double[] data = { 1, 2, 3, 4, 5 };
//            double tau = 0;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(1, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_TauIsOne()
//        {
//            // Arrange
//            double[] data = { 1, 2, 3, 4, 5 };
//            double tau = 1;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(5, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_TauIsLessThanZero()
//        {
//            // Arrange
//            double[] data = { 1, 2, 3, 4, 5 };
//            double tau = -1;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_TauIsGreaterThanOne()
//        {
//            // Arrange
//            double[] data = { 1, 2, 3, 4, 5 };
//            double tau = 2;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_EmptyArray()
//        {
//            // Arrange
//            double[] data = { };
//            double tau = 0.5;

//            // Act
//            double result = MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }

//        [TestMethod]
//        public void QuantileInplace_EdgeCase_NullArray()
//        {
//            // Arrange
//            double[] data = null;
//            double tau = 0.5;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau));
//        }
//    }
//}
