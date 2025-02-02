//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using MathNet.Numerics.Statistics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class WeightedPearsonTests
//    {
//        [TestMethod]
//        public void WeightedPearson_ValidInputs_ReturnsCorrectResult()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0, 3.0, 4.0 };
//            var dataB = new List<double> { 2.0, 4.0, 6.0, 8.0 };
//            var weights = new List<double> { 1.0, 1.0, 1.0, 1.0 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, result, 1e-6, "The correlation should be perfect (1.0).");
//        }

//        [TestMethod]
//        public void WeightedPearson_ZeroWeights_ReturnsNaN()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0, 3.0 };
//            var dataB = new List<double> { 4.0, 5.0, 6.0 };
//            var weights = new List<double> { 0.0, 0.0, 0.0 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "The result should be NaN when weights are zero.");
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_DifferentLengths_ThrowsException()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0 };
//            var dataB = new List<double> { 1.0, 2.0, 3.0 };
//            var weights = new List<double> { 1.0, 1.0 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void WeightedPearson_WeightsShorterThanData_ThrowsException()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0, 3.0 };
//            var dataB = new List<double> { 4.0, 5.0, 6.0 };
//            var weights = new List<double> { 1.0, 2.0 };

//            // Act
//            Correlation.WeightedPearson(dataA, dataB, weights);
//        }

//        [TestMethod]
//        public void WeightedPearson_HandlesNegativeWeights()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0, 3.0 };
//            var dataB = new List<double> { 3.0, 2.0, 1.0 };
//            var weights = new List<double> { -1.0, -2.0, -1.0 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(-1.0, result, 1e-6, "The correlation should be -1.0 for inverse relationship.");
//        }

//        [TestMethod]
//        public void WeightedPearson_AllZerosInDataA_ReturnsNaN()
//        {
//            // Arrange
//            var dataA = new List<double> { 0.0, 0.0, 0.0 };
//            var dataB = new List<double> { 1.0, 2.0, 3.0 };
//            var weights = new List<double> { 1.0, 1.0, 1.0 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result), "The result should be NaN when one dataset is constant.");
//        }

//        [TestMethod]
//        public void WeightedPearson_MixedWeights_ReturnsCorrectResult()
//        {
//            // Arrange
//            var dataA = new List<double> { 1.0, 2.0, 3.0 };
//            var dataB = new List<double> { 3.0, 6.0, 9.0 };
//            var weights = new List<double> { 0.5, 1.0, 1.5 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1.0, result, 1e-6, "The correlation should be 1.0 for perfectly correlated data.");
//        }
//    }
//}
