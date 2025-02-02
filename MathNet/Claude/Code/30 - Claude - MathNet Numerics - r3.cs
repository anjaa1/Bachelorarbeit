//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Tests.SpecialFunctionsTests
//{
//    [TestClass]
//    public class ExponentialIntegralTests
//    {
//        private const double RelativeAccuracy = 1e-13;

//        [TestMethod]
//        public void ExponentialIntegral_SpecialCaseN0_ReturnsExpectedResult()
//        {
//            // Arrange
//            double x = 2.0;
//            int n = 0;
//            double expected = Math.Exp(-x) / x;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(expected, result, RelativeAccuracy * Math.Abs(expected));
//        }

//        [TestMethod]
//        public void ExponentialIntegral_SpecialCaseX0_ReturnsExpectedResult()
//        {
//            // Arrange
//            double x = 0.0;
//            int n = 2;
//            double expected = 1.0;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(expected, result, RelativeAccuracy * Math.Abs(expected));
//        }

//        [TestMethod]
//        public void ExponentialIntegral_SeriesComputation_SmallX_Converges()
//        {
//            // Arrange
//            double x = 0.5;
//            int n = 2;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//            Assert.IsTrue(result > 0);
//        }

//        [TestMethod]
//        public void ExponentialIntegral_ContinuedFraction_LargeX_Converges()
//        {
//            // Arrange
//            double x = 2.0;
//            int n = 3;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//            Assert.IsTrue(result > 0);
//        }

//        [TestMethod]
//        [DataRow(-1.0, 1)]
//        [DataRow(1.0, -1)]
//        [DataRow(-1.0, -1)]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void ExponentialIntegral_InvalidInput_ThrowsArgumentOutOfRangeException(double x, int n)
//        {
//            // Act
//            SpecialFunctions.ExponentialIntegral(x, n);
//        }

//        [TestMethod]
//        public void ExponentialIntegral_VeryLargeX_DoesNotOverflow()
//        {
//            // Arrange
//            double x = 100.0;
//            int n = 1;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//            Assert.IsTrue(result > 0);
//        }

//        [TestMethod]
//        public void ExponentialIntegral_VerySmallX_DoesNotUnderflow()
//        {
//            // Arrange
//            double x = 1e-10;
//            int n = 2;

//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//            Assert.IsTrue(result > 0);
//        }

//        [TestMethod]
//        public void ExponentialIntegral_ConsecutiveN_ShowsExpectedBehavior()
//        {
//            // For fixed x, En(x) should decrease as n increases
//            double x = 1.5;
//            double previousResult = double.PositiveInfinity;

//            for (int n = 1; n <= 5; n++)
//            {
//                double currentResult = SpecialFunctions.ExponentialIntegral(x, n);
//                Console.WriteLine(currentResult);
//                Assert.IsTrue(currentResult < previousResult,
//                    $"En(x) should decrease with increasing n. Failed at n={n}");
//                previousResult = currentResult;
//            }
//        }

//        [TestMethod]
//        [DataRow(1.0, 1, 0.219383934395520274)]  // E?(1)
//        public void ExponentialIntegral_VerifyKnownValue(double x, int n, double expected)
//        {
//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.AreEqual(expected, result, RelativeAccuracy * Math.Abs(expected),
//                $"Failed for x={x}, n={n}");
//        }
//    }
//}
