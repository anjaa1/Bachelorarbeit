//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Statistics;
//using System;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ArrayStatisticsTests
//    {
//        [TestMethod]
//        public void RanksInplace_ValidData_AverageRanking()
//        {
//            // Arrange
//            double[] data = { 10, 20, 20, 40 };
//            double[] expectedRanks = { 1, 2.5, 2.5, 4 };

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone(), RankDefinition.Average);

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not compute correct ranks for average tie handling.");
//        }

//        [TestMethod]
//        public void RanksInplace_ValidData_MinRanking()
//        {
//            // Arrange
//            double[] data = { 10, 20, 20, 40 };
//            double[] expectedRanks = { 1, 2, 2, 4 };

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone(), RankDefinition.Min);

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not compute correct ranks for min tie handling.");
//        }

//        [TestMethod]
//        public void RanksInplace_ValidData_MaxRanking()
//        {
//            // Arrange
//            double[] data = { 10, 20, 20, 40 };
//            double[] expectedRanks = { 1, 3, 3, 4 };

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone(), RankDefinition.Max);

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not compute correct ranks for max tie handling.");
//        }

//        [TestMethod]
//        public void RanksInplace_EmptyArray()
//        {
//            // Arrange
//            double[] data = { };
//            double[] expectedRanks = { };

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone());

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not handle an empty array correctly.");
//        }

//        [TestMethod]
//        public void RanksInplace_NullArray_ThrowsException()
//        {
//            // Arrange
//            double[] data = null;

//            try
//            {
//                // Act
//                ArrayStatistics.RanksInplace(data);
//            }
//            catch (ArgumentNullException ex)
//            {
//                // Assert
//                StringAssert.Contains(ex.Message, "Value cannot be null");
//                return;
//            }

//            Assert.Fail("RanksInplace did not throw ArgumentNullException for null input.");
//        }

//        [TestMethod]
//        public void RanksInplace_SingleElementArray()
//        {
//            // Arrange
//            double[] data = { 42 };
//            double[] expectedRanks = { 1 };

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone());

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not handle a single-element array correctly.");
//        }

//        [TestMethod]
//        public void RanksInplace_AllIdenticalValues()
//        {
//            // Arrange
//            double[] data = { 5, 5, 5, 5 };
//            double[] expectedRanks = { 2.5, 2.5, 2.5, 2.5 }; // Average ranking by default

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone());

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not handle all identical values correctly.");
//        }

//        [TestMethod]
//        public void RanksInplace_MixedValues_FirstDefinition()
//        {
//            // Arrange
//            double[] data = { 10, 20, 10, 40 };
//            double[] expectedRanks = { 1, 3, 2, 4 }; // First rank definition

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone(), RankDefinition.First);

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not compute correct ranks with the First definition.");
//        }

//        [TestMethod]
//        public void RanksInplace_MixedValues_Decimals()
//        {
//            // Arrange
//            double[] data = { 1.1, 2.2, 1.1, 4.4 };
//            double[] expectedRanks = { 1.5, 3, 1.5, 4 }; // Average ranking by default

//            // Act
//            double[] actualRanks = ArrayStatistics.RanksInplace((double[])data.Clone());

//            // Assert
//            CollectionAssert.AreEqual(expectedRanks, actualRanks, "RanksInplace did not handle decimal values correctly.");
//        }
//    }
//}
