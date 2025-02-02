//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;
//using System;

//namespace MathNet.Numerics.Tests.StatisticsTests
//{
//    [TestClass]
//    public class ArrayStatisticsRanksInplaceTests
//    {
//        private const double Delta = 1e-10;

//        [TestMethod]
//        public void RanksInplace_SimpleSequence_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            double[] expected = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_ReversedSequence_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
//            double[] expected = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Average_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 2.5, 2.5, 4.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);  // Default is Average

//            // Assert
//            for (int i = 0; i < expected.Length; i++)
//            {
//                Assert.AreEqual(expected[i], result[i], Delta);
//            }
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Min_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 2.0, 2.0, 4.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Min);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Max_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 3.0, 3.0, 4.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Max);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_SingleElement_ReturnsRankOne()
//        {
//            // Arrange
//            double[] data = new double[] { 42.0 };
//            double[] expected = new double[] { 1.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_AllEqual_ReturnsEqualRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 1.0, 1.0, 1.0 };
//            double[] expected = new double[] { 2.5, 2.5, 2.5, 2.5 };  // Average of ranks 1,2,3,4

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);

//            // Assert
//            for (int i = 0; i < expected.Length; i++)
//            {
//                Assert.AreEqual(expected[i], result[i], Delta);
//            }
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void RanksInplace_NullInput_ThrowsArgumentNullException()
//        {
//            // Act
//            ArrayStatistics.RanksInplace(null);
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyArray_ReturnsEmptyArray()
//        {
//            // Arrange
//            double[] data = new double[0];

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);

//            // Assert
//            Assert.AreEqual(0, result.Length);
//        }

//        [TestMethod]
//        public void RanksInplace_WithNaN_HandlesCorrectly()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, double.NaN, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 4.0, 2.0, 3.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithInfinity_HandlesCorrectly()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, double.PositiveInfinity, 2.0, double.NegativeInfinity };
//            double[] expected = new double[] { 2.0, 4.0, 3.0, 1.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}
