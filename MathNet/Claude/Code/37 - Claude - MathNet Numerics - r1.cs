//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Statistics.Tests
//{
//    [TestClass]
//    public class ArrayStatisticsRanksInplaceTests
//    {
//        private const double Delta = 1e-10;

//        [TestMethod]
//        public void RanksInplace_SimpleSequence_ReturnsCorrectRanks()
//        {
//            // Arrange
//            var data = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var expected = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_ReversedSequence_ReturnsCorrectRanks()
//        {
//            // Arrange
//            var data = new[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
//            var expected = new[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Average_ReturnsCorrectRanks()
//        {
//            // Arrange
//            var data = new[] { 1.0, 2.0, 2.0, 3.0 };
//            var expected = new[] { 1.0, 2.5, 2.5, 4.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.Average);

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
//            var data = new[] { 1.0, 2.0, 2.0, 3.0 };
//            var expected = new[] { 1.0, 2.0, 2.0, 4.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.Min);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Max_ReturnsCorrectRanks()
//        {
//            // Arrange
//            var data = new[] { 1.0, 2.0, 2.0, 3.0 };
//            var expected = new[] { 1.0, 3.0, 3.0, 4.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.Max);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_SingleElement_ReturnsRankOne()
//        {
//            // Arrange
//            var data = new[] { 42.0 };
//            var expected = new[] { 1.0 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.Average);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_AllEqual_ReturnsEqualRanks()
//        {
//            // Arrange
//            var data = new[] { 1.0, 1.0, 1.0, 1.0 };
//            var expected = new[] { 2.5, 2.5, 2.5, 2.5 };
//            var dataCopy = (double[])data.Clone();

//            // Act
//            var result = ArrayStatistics.RanksInplace(dataCopy, RankDefinition.Average);

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
//            ArrayStatistics.RanksInplace(null, RankDefinition.Average);
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyArray_ReturnsEmptyArray()
//        {
//            // Arrange
//            var data = new double[0];

//            // Act
//            var result = ArrayStatistics.RanksInplace(data, RankDefinition.Average);

//            // Assert
//            Assert.AreEqual(0, result.Length);
//        }

//        [TestMethod]
//        public void RanksInplace_ModifiesOriginalArray()
//        {
//            // Arrange
//            var data = new[] { 3.0, 1.0, 2.0 };
//            var originalData = (double[])data.Clone();

//            // Act
//            ArrayStatistics.RanksInplace(data, RankDefinition.Average);

//            // Assert
//            CollectionAssert.AreNotEqual(originalData, data, "Original array should be modified");
//        }
//    }
//}
