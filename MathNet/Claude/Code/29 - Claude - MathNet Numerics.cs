//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Numerics;
//using System.Collections.Generic;
//using MathNet.Numerics.Statistics;
//using System;

//namespace MathNet.Numerics.Tests.StatisticsTests
//{
//    [TestClass]
//    public class StreamingStatisticsTests
//    {
//        private const double Epsilon = 1e-10;

//        [TestMethod]
//        public void MinimumMagnitudePhase_EmptyStream_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new List<Complex>();

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result.Real));
//            Assert.IsTrue(double.IsNaN(result.Imaginary));
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_SingleValue_ReturnsThatValue()
//        {
//            // Arrange
//            var value = new Complex(3, 4);
//            var stream = new List<Complex> { value };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(value.Real, result.Real, Epsilon);
//            Assert.AreEqual(value.Imaginary, result.Imaginary, Epsilon);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_StreamWithNaN_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(1, 1),
//                new Complex(double.NaN, 0),
//                new Complex(2, 2)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result.Real));
//            Assert.IsTrue(double.IsNaN(result.Imaginary));
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_DifferentMagnitudes_ReturnsSmallestMagnitude()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(3, 4),    // magnitude = 5
//                new Complex(1, 1),    // magnitude ≈ 1.414
//                new Complex(2, 2),    // magnitude ≈ 2.828
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(1, result.Real, Epsilon);
//            Assert.AreEqual(1, result.Imaginary, Epsilon);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_EqualMagnitudesDifferentPhases_ReturnsSmallestPhase()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(1, 1),     // magnitude ≈ 1.414, phase ≈ 0.785
//                new Complex(-1, -1),   // magnitude ≈ 1.414, phase ≈ -2.356
//                new Complex(1, -1)     // magnitude ≈ 1.414, phase ≈ -0.785
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(-1, result.Real, Epsilon);
//            Assert.AreEqual(-1, result.Imaginary, Epsilon);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_ZeroValues_HandlesProperly()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(0, 0),
//                new Complex(1, 1),
//                new Complex(2, 2)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(0, result.Real, Epsilon);
//            Assert.AreEqual(0, result.Imaginary, Epsilon);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_InfinityValues_HandlesProperly()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(double.PositiveInfinity, 0),
//                new Complex(1, 1),
//                new Complex(2, 2)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(1, result.Real, Epsilon);
//            Assert.AreEqual(1, result.Imaginary, Epsilon);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_NegativeValues_HandlesProperly()
//        {
//            // Arrange
//            var stream = new List<Complex>
//            {
//                new Complex(-2, -2),   // magnitude ≈ 2.828
//                new Complex(-1, -1),   // magnitude ≈ 1.414
//                new Complex(-3, -3)    // magnitude ≈ 4.242
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(-1, result.Real, Epsilon);
//            Assert.AreEqual(-1, result.Imaginary, Epsilon);
//        }
//    }
//}
