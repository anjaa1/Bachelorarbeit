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

//            // Additional test cases
//            a = 10.0;
//            y0 = 0.5;
//            expected = 1.791759469228055;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 5.0;
//            y0 = 0.5;
//            expected = 1.163570213258999;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 0.5;
//            y0 = 0.5;
//            expected = 0.6931471805599453;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 0.5;
//            y0 = 0.0;
//            expected = 0.0;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);

//            a = 0.5;
//            y0 = 1.0;
//            expected = double.PositiveInfinity;
//            actual = SpecialFunctions.GammaLowerRegularizedInv(a, y0);
//            Assert.AreEqual(expected, actual, 1e-12);
//        }
//    }
//}
