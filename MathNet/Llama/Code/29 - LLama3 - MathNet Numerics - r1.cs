//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using System.Linq;
//using MathNet.Numerics.Statistics;
//using Complex = System.Numerics.Complex;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class StreamingStatisticsTests
//    {
//        [TestMethod]
//        public void MinimumMagnitudePhase_ValidInput_SingleElement_ReturnsCorrectResult()
//        {
//            // Arrange
//            var stream = new Complex[] { new Complex(3.0, 4.0) };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(3.0, result.Real);
//            Assert.AreEqual(4.0, result.Imaginary);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_ValidInput_MultipleElements_ReturnsCorrectResult()
//        {
//            // Arrange
//            var stream = new Complex[] { new Complex(3.0, 4.0), new Complex(5.0, 6.0) };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(3.0, result.Real);
//            Assert.AreEqual(4.0, result.Imaginary);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_InputWithNaN_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new Complex[] { new Complex(3.0, 4.0), new Complex(double.NaN, double.NaN) };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(double.NaN, result.Real);
//            Assert.AreEqual(double.NaN, result.Imaginary);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_EmptyInput_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new Complex[] { };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(double.NaN, result.Real);
//            Assert.AreEqual(double.NaN, result.Imaginary);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_InputWithSingleNaN_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new Complex[] { new Complex(double.NaN, double.NaN) };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(double.NaN, result.Real);
//            Assert.AreEqual(double.NaN, result.Imaginary);
//        }

//        [TestMethod]
//        public void MinimumMagnitudePhase_InputWithMultipleNaN_ReturnsNaN()
//        {
//            // Arrange
//            var stream = new Complex[] { new Complex(double.NaN, double.NaN), new Complex(double.NaN, double.NaN) };

//            // Act
//            var result = StreamingStatistics.MinimumMagnitudePhase(stream);

//            // Assert
//            Assert.AreEqual(double.NaN, result.Real);
//            Assert.AreEqual(double.NaN, result.Imaginary);
//        }
//    }
//}
