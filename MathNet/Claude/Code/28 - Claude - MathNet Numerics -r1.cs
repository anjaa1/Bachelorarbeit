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
//            // Expected value calculated as:
//            // μx = 3, μy = 6
//            // Σ((x-μx)(y-μy)) = (-2*-4 + -1*-2 + 0*0 + 1*2 + 2*4) = 20
//            // result = 20/4 = 5
//            double expected = 5.0;

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
//            // Expected value calculated as:
//            // μx = 3, μy = 6
//            // Σ((x-μx)(y-μy)) = (-2*4 + -1*2 + 0*0 + 1*-2 + 2*-4) = -20
//            // result = -20/4 = -5
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
//            double[] samples2 = new double[] { 6, 6, 6, 6, 6 };
//            // With constant values in samples2, covariance should be 0
//            double expected = 0.0;

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }

//        [TestMethod]
//        public void Covariance_WithIEnumerableInput_CalculatesCorrectly()
//        {
//            // Arrange
//            IEnumerable<double> samples1 = Enumerable.Range(1, 5).Select(x => (double)x);
//            IEnumerable<double> samples2 = Enumerable.Range(2, 5).Select(x => (double)x);
//            // Expected value calculated as:
//            // samples1: [1,2,3,4,5], μx = 3
//            // samples2: [2,3,4,5,6], μy = 4
//            // Σ((x-μx)(y-μy)) = (-2*-2 + -1*-1 + 0*0 + 1*1 + 2*2) = 10
//            // result = 10/4 = 2.5
//            double expected = 2.5;

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.AreEqual(expected, result, Precision);
//        }

//        [TestMethod]
//        public void Covariance_SingleElement_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1.0 };
//            double[] samples2 = new double[] { 2.0 };

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
//        public void Covariance_UnequalLengths_ThrowsArgumentException()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1.0, 2.0, 3.0 };
//            double[] samples2 = new double[] { 1.0, 2.0 };

//            // Act
//            StreamingStatistics.Covariance(samples1, samples2);
//        }

//        [TestMethod]
//        public void Covariance_ContainsNaN_ReturnsNaN()
//        {
//            // Arrange
//            double[] samples1 = new double[] { 1.0, double.NaN, 3.0 };
//            double[] samples2 = new double[] { 4.0, 5.0, 6.0 };

//            // Act
//            double result = StreamingStatistics.Covariance(samples1, samples2);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result));
//        }
//    }
//}
