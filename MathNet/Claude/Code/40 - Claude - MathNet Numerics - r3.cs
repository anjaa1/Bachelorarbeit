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
//            // Values calculated using the actual implementation
//            var testCases = new[]
//            {
//                (freedom: 1.0, x: 1.0, expected: 0.24197072451914337),
//                (freedom: 2.0, x: 2.0, expected: 0.18393972058572117),
//                (freedom: 3.0, x: 3.0, expected: 0.15418032980376897)
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
//        public void PDF_LargeDegreesOfFreedom_ReturnsExpectedValue()
//        {
//            // Test with freedom > 160 to trigger the PDFLn path
//            double result = ChiSquared.PDF(161.0, 161.0);
//            Assert.IsTrue(result > 0.0);
//            Assert.IsFalse(double.IsInfinity(result));
//            Assert.IsFalse(double.IsNaN(result));
//        }
//    }
//}
