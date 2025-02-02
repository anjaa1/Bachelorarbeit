//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using System.Linq;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class CorrelationTests
//    {
//        [TestMethod]
//        public void WeightedPearson_TypicalCase()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double> { 2, 3, 5, 7, 11 };
//            var weights = new List<double> { 1, 1, 1, 1, 1 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(0.994, result, 1e-3);
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_SameData()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double> { 1, 2, 3, 4, 5 };
//            var weights = new List<double> { 1, 1, 1, 1, 1 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(1, result);
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_ZeroWeight()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double> { 2, 3, 5, 7, 11 };
//            var weights = new List<double> { 1, 0, 1, 1, 1 };

//            // Act
//            var result = Correlation.WeightedPearson(dataA, dataB, weights);

//            // Assert
//            Assert.AreEqual(0.994, result, 1e-3);
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_InvalidWeightLength()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double> { 2, 3, 5, 7, 11 };
//            var weights = new List<double> { 1, 1, 1 };

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Correlation.WeightedPearson(dataA, dataB, weights));
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_NullWeight()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double> { 2, 3, 5, 7, 11 };
//            var weights = new List<double>();

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Correlation.WeightedPearson(dataA, dataB, weights));
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_NullDataA()
//        {
//            // Arrange
//            var dataA = new List<double>();
//            var dataB = new List<double> { 2, 3, 5, 7, 11 };
//            var weights = new List<double> { 1, 1, 1, 1, 1 };

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Correlation.WeightedPearson(dataA, dataB, weights));
//        }

//        [TestMethod]
//        public void WeightedPearson_EdgeCase_NullDataB()
//        {
//            // Arrange
//            var dataA = new List<double> { 1, 2, 3, 4, 5 };
//            var dataB = new List<double>();
//            var weights = new List<double> { 1, 1, 1, 1, 1 };

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Correlation.WeightedPearson(dataA, dataB, weights));
//        }
//    }
//}
