//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class SeriesTests
//    {
//        [TestMethod]
//        public void Evaluate_TypicalCase_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
//            var expectedSum = 15.0;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_SingleElement_ReturnsElement()
//        {
//            // Arrange
//            var summand = 10.0;
//            var expectedSum = 10.0;

//            // Act
//            var actualSum = Series.Evaluate(new[] { summand });

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_EmptySequence_ReturnsZero()
//        {
//            // Act
//            var actualSum = Series.Evaluate(new double[0]);

//            // Assert
//            Assert.AreEqual(0.0, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_NullSequence_ThrowsArgumentNullException()
//        {
//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => Series.Evaluate(null));
//        }

//        [TestMethod]
//        public void Evaluate_SmallSummands_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { 0.0001, 0.0002, 0.0003, 0.0004, 0.0005 };
//            var expectedSum = 0.0015;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_LargeSummands_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { 1000000.0, 2000000.0, 3000000.0, 4000000.0, 5000000.0 };
//            var expectedSum = 15000000.0;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_ManySummands_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new double[10000];
//            for (int i = 0; i < 10000; i++)
//            {
//                summands[i] = i;
//            }
//            var expectedSum = 49995000.0;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_DuplicateSummands_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { 1.0, 2.0, 3.0, 2.0, 1.0 };
//            var expectedSum = 9.0;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_NegativeSummands_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { -1.0, -2.0, -3.0, -4.0, -5.0 };
//            var expectedSum = -15.0;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_Overflow_ReturnsCorrectSum()
//        {
//            // Arrange
//            var summands = new[] { double.MaxValue, double.MaxValue };
//            var expectedSum = double.PositiveInfinity;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }

//        [TestMethod]
//        public void Evaluate_NaN_ReturnsNaN()
//        {
//            // Arrange
//            var summands = new[] { double.NaN };
//            var expectedSum = double.NaN;

//            // Act
//            var actualSum = Series.Evaluate(summands);

//            // Assert
//            Assert.AreEqual(expectedSum, actualSum);
//        }
//    }
//}
