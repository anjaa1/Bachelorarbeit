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
//            double[] data = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            double[] expected = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_ReversedSequence_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
//            double[] expected = new double[] { 5.0, 4.0, 3.0, 2.0, 1.0 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Average_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 2.5, 2.5, 4.0 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.Default);

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
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.Min);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_WithTies_Max_ReturnsCorrectRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 2.0, 2.0, 3.0 };
//            double[] expected = new double[] { 1.0, 3.0, 3.0, 4.0 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.Max);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_SingleElement_ReturnsRankOne()
//        {
//            // Arrange
//            double[] data = new double[] { 42.0 };
//            double[] expected = new double[] { 1.0 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.Default);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void RanksInplace_AllEqual_ReturnsEqualRanks()
//        {
//            // Arrange
//            double[] data = new double[] { 1.0, 1.0, 1.0, 1.0 };
//            double[] expected = new double[] { 2.5, 2.5, 2.5, 2.5 };
//            double[] dataCopy = (double[])data.Clone();

//            // Act
//            double[] result = ArrayStatistics.RanksInplace((double[])dataCopy, RankDefinition.Default);

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
//            _ = ArrayStatistics.RanksInplace((double[])null, RankDefinition.Default);
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyArray_ReturnsEmptyArray()
//        {
//            // Arrange
//            double[] data = new double[0];

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Default);

//            // Assert
//            Assert.AreEqual(0, result.Length);
//        }

//        [TestMethod]
//        public void RanksInplace_ModifiesOriginalArray()
//        {
//            // Arrange
//            double[] data = new double[] { 3.0, 1.0, 2.0 };
//            double[] originalData = (double[])data.Clone();

//            // Act
//            _ = ArrayStatistics.RanksInplace(data, RankDefinition.Default);

//            // Assert
//            CollectionAssert.AreNotEqual(originalData, data, "Original array should be modified");
//        }
//    }
//}
