//using MathNet.Numerics;
//using MathNet.Numerics.Statistics;
//using MathNet.Numerics.Sorting;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MathNet.Numerics.Tests.Statistics
//{
//    [TestClass]
//    public class ArrayStatisticsTests
//    {
//        [TestMethod]
//        public void RanksInplace_TypicalCase()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 5.0 };
//            RankDefinition definition = RankDefinition.Average;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 4.0, 2.0, 5.0, 3.0 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_Ties()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 4.0 };
//            RankDefinition definition = RankDefinition.Average;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 4.0, 2.0, 4.5, 4.5 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_MultipleTies()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 4.0, 4.0 };
//            RankDefinition definition = RankDefinition.Average;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 4.0, 2.0, 4.5, 4.5, 4.5 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_FirstRankDefinition()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 5.0 };
//            RankDefinition definition = RankDefinition.First;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_MinRankDefinition()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 4.0 };
//            RankDefinition definition = RankDefinition.Min;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 2.0, 3.0, 4.0, 4.0 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_MaxRankDefinition()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 4.0 };
//            RankDefinition definition = RankDefinition.Max;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[] { 1.0, 2.0, 3.0, 4.0, 4.0 }, ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_NullData()
//        {
//            // Arrange
//            double[] data = null;
//            RankDefinition definition = RankDefinition.Average;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => ArrayStatistics.RanksInplace(data, definition));
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyData()
//        {
//            // Arrange
//            double[] data = new double[0];
//            RankDefinition definition = RankDefinition.Average;

//            // Act
//            double[] ranks = ArrayStatistics.RanksInplace(data, definition);

//            // Assert
//            CollectionAssert.AreEqual(new double[0], ranks);
//        }

//        [TestMethod]
//        public void RanksInplace_NullDefinition()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 5.0 };
//            RankDefinition definition = null;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => ArrayStatistics.RanksInplace(data, definition));
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyDefinition()
//        {
//            // Arrange
//            double[] data = { 1.0, 3.0, 2.0, 4.0, 5.0 };
//            RankDefinition definition = RankDefinition.Empty;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => ArrayStatistics.RanksInplace(data, definition));
//        }
//    }
//}
