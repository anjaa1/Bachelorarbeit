//using System;
//using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class StreamingStatisticsTests
//    {
//        [TestMethod]
//        public void Covariance_TypicalCase_ReturnsExpectedResult()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var samples2 = new List<double> { 5.0, 4.0, 3.0, 2.0, 1.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(-2.5, result, 1e-9, "The covariance for typical inputs did not match the expected value.");
//        }

//        [TestMethod]
//        public void Covariance_EmptyInput_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new List<double>();
//            var samples2 = new List<double>();

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "The covariance for empty inputs should return NaN.");
//        }

//        [TestMethod]
//        public void Covariance_SingleElement_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0 };
//            var samples2 = new List<double> { 2.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "The covariance for single-element inputs should return NaN.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Covariance_DifferentLengths_ThrowsArgumentException()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, 2.0 };
//            var samples2 = new List<double> { 1.0 };

//            // Act
//            StreamingStatistics.Covariance(samples1, samples2);
//        }

//        [TestMethod]
//        public void Covariance_ContainsNaN_ReturnsNaN()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, double.NaN, 3.0 };
//            var samples2 = new List<double> { 4.0, 5.0, 6.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "The covariance should return NaN when inputs contain NaN.");
//        }

//        [TestMethod]
//        public void Covariance_IdenticalSamples_ReturnsVariance()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples1);

//            // Assert
//            Assert.AreEqual(2.5, result, 1e-9, "The covariance of identical samples did not return the expected variance.");
//        }

//        [TestMethod]
//        public void Covariance_PositiveCorrelation_ReturnsPositiveValue()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var samples2 = new List<double> { 2.0, 4.0, 6.0, 8.0, 10.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(result > 0, "The covariance for positively correlated inputs should return a positive value.");
//        }

//        [TestMethod]
//        public void Covariance_NegativeCorrelation_ReturnsNegativeValue()
//        {
//            // Arrange
//            var samples1 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var samples2 = new List<double> { 10.0, 8.0, 6.0, 4.0, 2.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(result < 0, "The covariance for negatively correlated inputs should return a negative value.");
//        }
//    }
//}
