//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics.Distributions;
//using System;

//namespace MathNet.Numerics.Tests.Distributions
//{
//    [TestClass]
//    public class ChiSquaredTests
//    {
//        [TestMethod]
//        [DataRow(1.0, 2.0, 0.1037768743551487)] // Typical case
//        [DataRow(2.0, 1.0, 0.3032653298563167)] // Typical case
//        [DataRow(3.0, 2.0, 0.2075537487102974)] // Typical case
//        [DataRow(5.0, 0.1, 0.004000129828100442)] // Edge case: small x
//        [DataRow(160.0, 80.0, 8.675455922569073E-09)] // Edge case: large degrees of freedom
//        public void PDF_ValidInputs_ReturnsExpectedDensity(double freedom, double x, double expected)
//        {
//            // Act
//            double actual = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(expected, actual, 1e-12, "PDF did not return the expected value.");
//        }

//        [TestMethod]
//        [DataRow(0.0, 2.0)] // Invalid degrees of freedom
//        [DataRow(-1.0, 2.0)] // Negative degrees of freedom
//        public void PDF_InvalidFreedom_ThrowsArgumentException(double freedom, double x)
//        {
//            // Act & Assert
//            Assert.ThrowsException<ArgumentException>(() => ChiSquared.PDF(freedom, x), "Invalid degrees of freedom should throw ArgumentException.");
//        }

//        [TestMethod]
//        [DataRow(1.0, 0.0)] // x = 0
//        [DataRow(2.0, double.PositiveInfinity)] // x = Infinity
//        [DataRow(double.PositiveInfinity, 1.0)] // freedom = Infinity
//        public void PDF_SpecialCases_ReturnsZero(double freedom, double x)
//        {
//            // Act
//            double actual = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.AreEqual(0.0, actual, 1e-12, "PDF did not return 0.0 for special cases.");
//        }

//        [TestMethod]
//        public void PDF_VeryLargeFreedom_ReturnsExpectedDensity()
//        {
//            // Arrange
//            double freedom = 161.0; // Larger than threshold in method
//            double x = 80.0;

//            // Act
//            double actual = ChiSquared.PDF(freedom, x);

//            // Assert
//            Assert.IsTrue(actual > 0.0, "PDF should return a valid density for large degrees of freedom.");
//        }
//    }
//}
