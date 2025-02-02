//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Statistics.Tests
//{
//    [TestClass]
//    public class ArrayStatisticsRanksInplaceTests
//    {
//        private const double Delta = 1e-10;

//        [TestMethod]
//        [ExpectedException(typeof(NullReferenceException))]
//        public void RanksInplace_NullInput_ThrowsNullReferenceException()
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
//        public void RanksInplace_SingleValue_ReturnsRankOne()
//        {
//            // Arrange
//            double[] data = new double[] { 42.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Default);

//            // Assert
//            Assert.AreEqual(1, result.Length);
//            Assert.AreEqual(1.0, result[0], Delta);
//        }

//        [TestMethod]
//        public void RanksInplace_Default_HandlesBasicSequence()
//        {
//            // Arrange
//            double[] data = new double[] { 3.0, 1.0, 4.0, 1.0, 5.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Default);

//            // Assert
//            Assert.AreEqual(5, result.Length);
//            Assert.AreEqual(1.5, result[1], Delta); // First 1.0
//            Assert.AreEqual(1.5, result[3], Delta); // Second 1.0
//            Assert.AreEqual(3.0, result[0], Delta); // 3.0
//            Assert.AreEqual(4.0, result[2], Delta); // 4.0
//            Assert.AreEqual(5.0, result[4], Delta); // 5.0
//        }

//        [TestMethod]
//        public void RanksInplace_First_PreservesOriginalOrder()
//        {
//            // Arrange
//            double[] data = new double[] { 3.0, 1.0, 4.0, 1.0, 5.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.First);

//            // Assert
//            Assert.AreEqual(5, result.Length);
//            Assert.AreEqual(3.0, result[0]); // 3.0
//            Assert.AreEqual(1.0, result[1]); // First 1.0
//            Assert.AreEqual(4.0, result[2]); // 4.0
//            Assert.AreEqual(2.0, result[3]); // Second 1.0
//            Assert.AreEqual(5.0, result[4]); // 5.0
//        }

//        [TestMethod]
//        public void RanksInplace_Min_AssignsMinimumRankForTies()
//        {
//            // Arrange
//            double[] data = new double[] { 3.0, 1.0, 4.0, 1.0, 5.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Min);

//            // Assert
//            Assert.AreEqual(5, result.Length);
//            Assert.AreEqual(1.0, result[1], Delta); // First 1.0
//            Assert.AreEqual(1.0, result[3], Delta); // Second 1.0
//            Assert.AreEqual(3.0, result[0], Delta); // 3.0
//            Assert.AreEqual(4.0, result[2], Delta); // 4.0
//            Assert.AreEqual(5.0, result[4], Delta); // 5.0
//        }

//        [TestMethod]
//        public void RanksInplace_Max_AssignsMaximumRankForTies()
//        {
//            // Arrange
//            double[] data = new double[] { 3.0, 1.0, 4.0, 1.0, 5.0 };

//            // Act
//            double[] result = ArrayStatistics.RanksInplace(data, RankDefinition.Max);

//            // Assert
//            Assert.AreEqual(5, result.Length);
//            Assert.AreEqual(2.0, result[1], Delta); // First 1.0
//            Assert.AreEqual(2.0, result[3], Delta); // Second 1.0
//            Assert.AreEqual(3.0, result[0], Delta); // 3.0
//            Assert.AreEqual(4.0, result[2], Delta); // 4.0
//            Assert.AreEqual(5.0, result[4], Delta); // 5.0
//        }
//    }
//}
