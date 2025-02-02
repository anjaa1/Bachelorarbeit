//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class StreamingStatisticsTests
//    {

//        [TestMethod]
//        public void Covariance_TypicalScenario_ReturnsCorrectValue()
//        {
//            // Arrange
//            var samples1 = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var samples2 = new[] { 6.0, 7.0, 8.0, 9.0, 10.0 };

//            // Act
//            var result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            var expectedCovariance = (samples1.Average() - 3) * (samples2.Average() - 7);
//            Assert.AreEqual(expectedCovariance, result);
//        }

//        [TestMethod]
//        public void Covariance_EdgeCase_DifferentLengths_ThrowsArgumentException()
//        {
//            // Arrange
//            var samples1 = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var samples2 = new[] { 6.0, 7.0, 8.0, 9.0 };

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => StreamingStatistics.Covariance(samples1, samples2));
//        }

//        [TestMethod]
//        public void Covariance_EdgeCase_SingleValue_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new[] { 1.0 };
//            var samples2 = new[] { 6.0 };

//            // Act
//            var result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }

//        [TestMethod]
//        public void Covariance_EdgeCase_NaNValue_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new[] { 1.0, double.NaN };
//            var samples2 = new[] { 6.0, 7.0 };

//            // Act
//            var result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }

//        [TestMethod]
//        public void Covariance_EdgeCase_EmptyArray_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new double[0];
//            var samples2 = new double[0];

//            // Act
//            var result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(double.NaN, result);
//        }
//    }
//}
