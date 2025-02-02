//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using MathNet.Numerics.Statistics;

//namespace StreamingStatisticsTests
//{
//    [TestClass]
//    public class MinimumMagnitudePhaseTests
//    {
//        [TestMethod]
//        public void MinimumMagnitudePhase_TypicalCase_ReturnsCorrectValue()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(3, 4),  // Magnitude = 5
//                new Complex(1, 1),  // Magnitude = sqrt(2)
//                new Complex(2, 2)   // Magnitude = sqrt(8)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.AreEqual(new Complex(1, 1), result);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_EmptyInput_ReturnsNaN()
//        {
//            // Arrange
//            var data = new List<Complex>();

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result.Real));
//            Assert.IsTrue(double.IsNaN(result.Imaginary));
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_AllNaNInputs_ReturnsNaN()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(double.NaN, double.NaN),
//                new Complex(double.NaN, double.NaN)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result.Real));
//            Assert.IsTrue(double.IsNaN(result.Imaginary));
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_MixedValidAndNaNInputs_ReturnsNaN()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(3, 4),
//                new Complex(double.NaN, double.NaN),
//                new Complex(1, 1)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.IsTrue(double.IsNaN(result.Real));
//            Assert.IsTrue(double.IsNaN(result.Imaginary));
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_SameMagnitudesDifferentPhases_ReturnsSmallestPhase()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(1, 1), // Phase = 0.785...
//                new Complex(-1, 1), // Phase = 2.356...
//                new Complex(1, -1)  // Phase = -0.785...
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.AreEqual(new Complex(1, -1), result);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_NegativeRealImaginary_ReturnsCorrectValue()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(-3, -4), // Magnitude = 5
//                new Complex(-1, -1)  // Magnitude = sqrt(2)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.AreEqual(new Complex(-1, -1), result);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_SingleElement_ReturnsElement()
//        {
//            // Arrange
//            var data = new List<Complex>
//            {
//                new Complex(5, 5)
//            };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.AreEqual(new Complex(5, 5), result);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_LargeDataset_ReturnsCorrectValue()
//        {
//            // Arrange
//            var data = Enumerable.Range(1, 10000).Select(x => new Complex(x, x)).ToList();

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(data);

//            // Assert
//            Assert.AreEqual(new Complex(1, 1), result);
//        }
//    }
//}
