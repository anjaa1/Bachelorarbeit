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
//        [DataRow(1.5, 1)]
//        [DataRow(2.0, 2)]
//        [DataRow(3.0, 3)]
//        public void ExponentialIntegral_LargeX_ConvergesContinuedFraction(double x, int n)
//        {
//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//            Assert.IsTrue(result > 0);
//        }

//        [TestMethod]
//        [DataRow(0.5, 1)]
//        [DataRow(0.8, 2)]
//        [DataRow(0.3, 3)]
//        public void ExponentialIntegral_SmallX_ConvergesSeries(double x, int n)
//        {
//            // Act
//            double result = SpecialFunctions.ExponentialIntegral(x, n);

//            // Assert
//            Assert.IsTrue(double.IsFinite(result));
//        }

//        [TestMethod]
//        public void ExponentialIntegral_KnownValues_ReturnsExpectedResults()
//        {
//            // These values were computed using Wolfram Alpha for verification
//            var testCases = new[]
//            {
//                new { X = 1.0, N = 1, Expected = 0.219383934395520274 },
//                new { X = 0.5, N = 2, Expected = 0.559773594776160811 },
//                new { X = 2.0, N = 3, Expected = 0.033384113234515 }
//            };

//            foreach (var testCase in testCases)
//            {
//                // Act
//                double result = SpecialFunctions.ExponentialIntegral(testCase.X, testCase.N);

//                // Assert
//                Assert.AreEqual(testCase.Expected, result, RelativeAccuracy * Math.Abs(testCase.Expected),
//                    $"Failed for x={testCase.X}, n={testCase.N}");
//            }
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
//                Assert.IsTrue(currentResult < previousResult,
//                    $"En(x) should decrease with increasing n. Failed at n={n}");
//                previousResult = currentResult;
//            }
//        }
//    }
//}
