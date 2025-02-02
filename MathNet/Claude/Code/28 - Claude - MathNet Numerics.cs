//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using MathNet.Numerics.Statistics;

//namespace MathNet.Numerics.Tests.StatisticsTests
//{
//    [TestClass]
//    public class StreamingStatisticsTests
//    {
//        private const double Precision = 1e-10;

//        [TestMethod]
//        public void Covariance_SimplePositiveCorrelation_ReturnsExpectedResult()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, 2, 3, 4, 5 };
//            double[] samples2 = new double[] { 2, 4, 6, 8, 10 };
//            double expected = 5.0; // Calculated manually: Cov(X,Y) = Σ((x-μx)(y-μy))/(n-1)

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }

//        [TestMethod]
//        public void Covariance_NegativeCorrelation_ReturnsExpectedResult()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, 2, 3, 4, 5 };
//            double[] samples2 = new double[] { 10, 8, 6, 4, 2 };
//            double expected = -5.0;

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }

//        [TestMethod]
//        public void Covariance_NoCorrelation_ReturnsZero()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, 2, 3, 4, 5 };
//            double[] samples2 = new double[] { 2, 2, 2, 2, 2 };
//            double expected = 0.0;

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }

//        [TestMethod]
//        public void Covariance_SingleElement_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1 };
//            double[] samples2 = new double[] { 2 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void Covariance_EmptyArrays_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = Array.Empty<double>();
//            double[] samples2 = Array.Empty<double>();

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Covariance_UnequalLengths_FirstLonger_ThrowsArgumentException()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, 2, 3 };
//            double[] samples2 = new double[] { 1, 2 };

//            // Act
//            StreamingStatistics.Covariance(samples1, samples2);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void Covariance_UnequalLengths_SecondLonger_ThrowsArgumentException()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, 2 };
//            double[] samples2 = new double[] { 1, 2, 3 };

//            // Act
//            StreamingStatistics.Covariance(samples1, samples2);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        public void Covariance_ContainsNaN_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, double.NaN, 3 };
//            double[] samples2 = new double[] { 4, 5, 6 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void Covariance_LargeValues_HandlesOverflowCorrectly()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1e15, 2e15, 3e15 };
//            double[] samples2 = new double[] { 4e15, 5e15, 6e15 };
//            double expected = 1e30; // Approximate expected value

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, expected * Precision);
//        }

//        [TestMethod]
//        public void Covariance_WithInfinities_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1, double.PositiveInfinity, 3 };
//            double[] samples2 = new double[] { 4, 5, 6 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }

//        [TestMethod]
//        public void Covariance_WithIEnumerableInput_CalculatesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> samples1 = Enumerable.Range(1, 5).Select(x => (double)x);
//            IEnumerable<double> samples2 = Enumerable.Range(1, 5).Select(x => (double)x * 2);
//            double expected = 2.5;

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }
//    }
//}
