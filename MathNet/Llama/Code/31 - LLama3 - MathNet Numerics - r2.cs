//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;

//namespace MathNet.Numerics.Test
//{
//    [TestClass]
//    public class SpecialFunctionsTest
//    {
//        [TestMethod]
//        public void TestGammaLowerRegularizedInv()
//        {
//            // Typical cases
//            double a = 1.0;
//            double y0 = 0.5;
//            double expected = 0.6931471805599453;
//            double actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 2.0;
//            y0 = 0.5;
//            expected = 0.5868273315166673;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 3.0;
//            y0 = 0.5;
//            expected = 0.4227841979448134;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Edge cases
//            a = 0.0;
//            y0 = 0.5;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 1.0;
//            y0 = 0.0;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 1.0;
//            y0 = 1.0;
//            expected = double.PositiveInfinity;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Invalid inputs
//            a = -1.0;
//            y0 = 0.5;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = double.NaN;
//            y0 = 0.5;
//            expected = double.NaN;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 1.0;
//            y0 = double.NaN;
//            expected = double.NaN;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 1.0;
//            y0 = -0.5;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Test with very small values of y0
//            a = 1.0;
//            y0 = 1e-10;
//            expected = double.PositiveInfinity;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Test with very large values of y0
//            a = 1.0;
//            y0 = 0.9999999999999999;
//            expected = double.PositiveInfinity;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Test with y0 close to 0
//            a = 1.0;
//            y0 = 1e-6;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            // Test with y0 close to 1
//            a = 1.0;
//            y0 = 0.999999;
//            expected = double.PositiveInfinity;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);
//        }
//    }
//}
