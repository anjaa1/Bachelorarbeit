//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using MathNet.Numerics.Statistics;

//namespace MathNet.Numerics.Statistics.Tests
//{
//    [TestClass]
//    public class CorrelationWeightedPearsonTests
//    {
//        private const double Tolerance = 1e-10;

//        [TestMethod]
//        public void WeightedPearson_PerfectPositiveCorrelation_ReturnsOne()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4, 5 };
//            double[] dataB = new double[] { 2, 4, 6, 8, 10 };
//            double[] weights = new double[] { 1, 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_PerfectNegativeCorrelation_ReturnsNegativeOne()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4, 5 };
//            double[] dataB = new double[] { 5, 4, 3, 2, 1 };
//            double[] weights = new double[] { 1, 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(-1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_NoCorrelation_ReturnsZero()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4, 5 };
//            double[] dataB = new double[] { 1, 1, 1, 1, 1 };
//            double[] weights = new double[] { 1, 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(0.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_DifferentWeights_CalculatesCorrectly()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4 };
//            double[] dataB = new double[] { 2, 4, 6, 8 };
//            double[] weights = new double[] { 0.5, 1.0, 1.5, 2.0 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_SingleElement_ReturnsNaN()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1 };
//            double[] dataB = new double[] { 2 };
//            double[] weights = new double[] { 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.IsTrue(double.IsNaN(correlation));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_UnequalLengthDataA_ThrowsArgumentOutOfRangeException()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3 };
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1, 1 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_UnequalLengthWeights_ThrowsArgumentOutOfRangeException()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2 };
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void WeightedPearson_NullDataA_ThrowsArgumentNullException()
//        {
//            // Arrange
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1, 1 };

//            // Act
//            Correlation.WeightedPearson(null, dataB, weights);
//        }

//        [TestMethod]
//        public void WeightedPearson_EmptyArrays_ReturnsNaN()
//        {
//            // Arrange
//            double[] dataA = Array.Empty<double>();
//            double[] dataB = Array.Empty<double>();
//            double[] weights = Array.Empty<double>();

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.IsTrue(double.IsNaN(correlation));
//        }

//        [TestMethod]
//        public void WeightedPearson_ZeroWeights_ReturnsNaN()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3 };
//            double[] dataB = new double[] { 2, 4, 6 };
//            double[] weights = new double[] { 0, 0, 0 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.IsTrue(double.IsNaN(correlation));
//        }
//    }
//}
