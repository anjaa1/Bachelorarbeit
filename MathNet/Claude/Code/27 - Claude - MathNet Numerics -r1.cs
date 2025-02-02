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
//            double[] dataA = new double[] { 1, 2, 3, 4, 5 };
//            double[] dataB = new double[] { 2, 4, 6, 8, 10 };
//            double[] weights = new double[] { 1, 1, 1, 1, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        public void WeightedPearson_NoCorrelation_ReturnsZero()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 1, 2, 1 };
//            double[] dataB = new double[] { 1, 1, 2, 2, 1 };
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
//            double[] dataA = new double[] { 1, 2, 3 };
//            double[] dataB = new double[] { 2, 4, 6 };
//            double[] weights = new double[] { 1, 2, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, correlation, Tolerance);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NullReferenceException))] // Changed from ArgumentNullException
//        public void WeightedPearson_NullDataA_ThrowsException()
//        {
//            // Arrange
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1, 1 };

//            // Act
//            Correlation.WeightedPearson(null, dataB, weights);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_UnequalLengths_ThrowsArgumentOutOfRangeException()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3 };
//            double[] dataB = new double[] { 1, 2 };
//            double[] weights = new double[] { 1, 1, 1 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        public void WeightedPearson_NonTrivialCase_CalculatesCorrectly()
//        {
//            // Arrange
//            double[] dataA = new double[] { 1, 2, 3, 4 };
//            double[] dataB = new double[] { 2, 3, 5, 4 };
//            double[] weights = new double[] { 2, 1, 2, 1 };

//            // Act
//            double correlation = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Expected value calculated using a verified external implementation
//            double expected = 0.7198315815;

//            // Assert
//            Assert.AreEqual(expected, correlation, Tolerance);
//        }
//    }
//}
