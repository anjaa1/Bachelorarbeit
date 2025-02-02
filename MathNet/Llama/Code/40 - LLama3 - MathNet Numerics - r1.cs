//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Distributions;
//using MathNet.Numerics.Random;
//using MathNet.Numerics.Threading;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class ChiSquaredTests
//    {
//        [TestMethod]
//        public void PDF_Valid_Freedom_ReturnsCorrectDensity()
//        {
//            // Arrange
//            double freedom = 5.0;
//            double x = 1.0;

//            // Act
//            double result = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(result, (Math.Pow(x, (freedom / 2.0) - 1.0) * Math.Exp(-x / 2.0)) / (Math.Pow(2.0, freedom / 2.0) * MathNet.Numerics.Distributions.Gamma(freedom / 2.0)));
//        }

//        [TestMethod]
//        public void PDF_Invalid_Freedom_ThrowsArgumentException()
//        {
//            // Arrange
//            double freedom = 0.0;
//            double x = 1.0;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => ChiSquared.PDF(freedom, x));
//        }

//        [TestMethod]
//        public void PDF_Degenerate_Cases_ReturnsZero()
//        {
//            // Arrange
//            double freedom = 5.0;
//            double x = double.PositiveInfinity;

//            // Act
//            double result = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(result, 0.0);
//        }

//        [TestMethod]
//        public void PDF_Extreme_Freedom_ReturnsApproximation()
//        {
//            // Arrange
//            double freedom = 160.0;
//            double x = 1.0;

//            // Act
//            double result = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(result, Math.Exp(MathNet.Numerics.Distributions.PDFLn(freedom, x)));
//        }

//        [TestMethod]
//        public void PDF_Negative_Freedom_ThrowsArgumentException()
//        {
//            // Arrange
//            double freedom = -5.0;
//            double x = 1.0;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => ChiSquared.PDF(freedom, x));
//        }

//        [TestMethod]
//        public void PDF_Negative_X_ReturnsZero()
//        {
//            // Arrange
//            double freedom = 5.0;
//            double x = -1.0;

//            // Act
//            double result = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(result, 0.0);
//        }

//        [TestMethod]
//        public void PDF_Zero_X_ReturnsZero()
//        {
//            // Arrange
//            double freedom = 5.0;
//            double x = 0.0;

//            // Act
//            double result = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(result, 0.0);
//        }

//        private double PDFLn(double freedom, double x)
//        {
//            return MathNet.Numerics.Distributions.PDFLn(freedom, x);
//        }
//    }
//}
