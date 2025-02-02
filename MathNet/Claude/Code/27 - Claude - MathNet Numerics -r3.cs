//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;

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
//            double[] dataA = new double[] { 1, 2, 3, 4 };
//            double[] dataB = new double[] { 2, 4, 6, 8 };
//            double[] weights = new double[] { 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_PerfectNegativeCorrelation_ReturnsMinusOne()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4 };
//            double[] dataB = new double[] { 8, 6, 4, 2 };
//            double[] weights = new double[] { 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(-1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_NoCorrelation_ReturnsZero()
//        {
//            // Arrange - Using orthogonal sequences for zero correlation
//            double[] dataA = new double[] { 1, 1, -1, -1 };
//            double[] dataB = new double[] { 1, -1, 1, -1 };
//            double[] weights = new double[] { 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(0.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_KnownCorrelation_CalculatesCorrectly()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3 };
//            double[] dataB = new double[] { 2, 3, 5 };
//            double[] weights = new double[] { 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Expected value is pre-calculated
//            double expected = 0.9819805060619656;

//            // Assert
//            Assert.AreEqual(expected, correlation, Tolerance);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_UnequalLengths_ThrowsArgumentOutOfRangeException()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2 };
//            double[] dataB = new double[] { 1 };
//            double[] weights = new double[] { 1, 1 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NullReferenceException))]
//        public void WeightedPearson_NullInput_ThrowsNullReferenceException()
//        {
//            // Arrange
//            double[] dataA = null;
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1, 1 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }
//    }
//}
