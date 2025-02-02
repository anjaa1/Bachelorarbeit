//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using MathNet.Numerics.Distributions;

//namespace MathNet.Numerics.Tests.DistributionsTests
//{
//    [TestClass]
//    public class ChiSquaredTests
//    {
//        private const double Precision = 1e-10;

//        [TestMethod]
//        public void PDF_ValidInputs_ReturnsExpectedValue()
//        {
//            // Known values calculated using statistical software
//            var testCases = new[]
//            {
//                (freedom: 1.0, x: 1.0, expected: 0.241970724519143),
//                (freedom: 2.0, x: 1.0, expected: 0.303265329856317),
//                (freedom: 5.0, x: 2.0, expected: 0.180031876845467)
//            };

//            foreach (var (freedom, x, expected) in testCases)
//            {
//                double actual = ChiSquared.PDF(freedom, x);
//                Assert.AreEqual(expected, actual, Precision,
//                    $"PDF failed for freedom={freedom}, x={x}");
//            }
//        }

//        [TestMethod]
//        public void PDF_ZeroX_ReturnsZero()
//        {
//            double result = ChiSquared.PDF(1.0, 0.0);
//            Assert.AreEqual(0.0, result);
//        }

//        [TestMethod]
//        public void PDF_LargeDegreesOfFreedom_ReturnsNonZeroValue()
//        {
//            // Test with freedom > 160 to trigger the PDFLn path
//            double result = ChiSquared.PDF(161.0, 161.0);
//            Assert.IsTrue(result > 0.0);
//            Assert.IsFinite(result);
//        }

//        [TestMethod]
//        public void PDF_InfiniteX_ReturnsZero()
//        {
//            double result = ChiSquared.PDF(1.0, double.PositiveInfinity);
//            Assert.AreEqual(0.0, result);
//        }

//        [TestMethod]
//        public void PDF_InfiniteDegreesOfFreedom_ReturnsZero()
//        {
//            double result = ChiSquared.PDF(double.PositiveInfinity, 1.0);
//            Assert.AreEqual(0.0, result);
//        }

//        [TestMethod]
//        [DataRow(0.0)]  // Zero degrees of freedom
//        [DataRow(-1.0)] // Negative degrees of freedom
//        public void PDF_InvalidDegreesOfFreedom_ThrowsArgumentException(double freedom)
//        {
//            Assert.ThrowsException<ArgumentException>(() => ChiSquared.PDF(freedom, 1.0),
//                "PDF should throw ArgumentException for invalid degrees of freedom");
//        }

//        [TestMethod]
//        public void PDF_NegativeX_ReturnsValidResult()
//        {
//            // The implementation doesn't explicitly handle negative x values,
//            // but we should test the behavior for completeness
//            double result = ChiSquared.PDF(1.0, -1.0);
//            Assert.IsFinite(result);
//        }

//        [TestMethod]
//        public void PDF_SpecialCases_HandledCorrectly()
//        {
//            // Test with very small values
//            Assert.IsFinite(ChiSquared.PDF(0.1, 0.1));

//            // Test with very large finite values
//            Assert.IsFinite(ChiSquared.PDF(100.0, 1000.0));

//            // Test with values close to machine epsilon
//            Assert.IsFinite(ChiSquared.PDF(1.0, double.Epsilon));
//        }
//    }
//}
