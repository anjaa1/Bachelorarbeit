//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Numerics;
//using MathNet.Numerics.RootFinding;

//namespace MathNet.Numerics.Tests.RootFindingTests
//{
//    [TestClass]
//    public class CubicTests
//    {
//        private const double Precision = 1e-10;

//        private static Complex EvaluateCubic(Complex x, double a, double b, double c, double d)
//        {
//            return a * x * x * x + b * x * x + c * x + d;
//        }

//        [TestMethod]
//        public void Roots_SimpleCase_RootsSatisfyEquation()
//        {
//            // x³ + x = 0
//            double a = 1, b = 0, c = 1, d = 0;
//            var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//            // Verify each root satisfies the equation
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root1, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root2, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root3, a, b, c, d)) < Precision);
//        }

//        [TestMethod]
//        public void Roots_AllCoefficientsNonZero_RootsSatisfyEquation()
//        {
//            // x³ + 2x² + 2x + 1 = 0
//            double a = 1, b = 2, c = 2, d = 1;
//            var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//            // Verify each root satisfies the equation
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root1, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root2, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root3, a, b, c, d)) < Precision);
//        }

//        [TestMethod]
//        public void Roots_ZeroConstantTerm_HasZeroRoot()
//        {
//            // x³ + x² = 0 = x(x² + x)
//            double a = 1, b = 1, c = 0, d = 0;
//            var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//            // Verify roots satisfy equation
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root1, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root2, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root3, a, b, c, d)) < Precision);

//            // At least one root should be zero
//            Assert.IsTrue(root1.Magnitude < Precision ||
//                        root2.Magnitude < Precision ||
//                        root3.Magnitude < Precision);
//        }

//        [TestMethod]
//        public void Roots_AllZeroCoefficientsExceptLeading_AllRootsZero()
//        {
//            // x³ = 0
//            double a = 1, b = 0, c = 0, d = 0;
//            var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//            // All roots should be zero
//            Assert.IsTrue(root1.Magnitude < Precision);
//            Assert.IsTrue(root2.Magnitude < Precision);
//            Assert.IsTrue(root3.Magnitude < Precision);
//        }

//        //[TestMethod]
//        //[ExpectedException(typeof(DivideByZeroException))]
//        //public void Roots_ZeroLeadingCoefficient_ThrowsException()
//        //{
//        //    // If leading coefficient is zero, it's not a cubic equation
//        //    double a = 0, b = 1, c = 1, d = 1;
//        //    _ = Cubic.Roots(d, c, b, a);
//        //}

//        [TestMethod]
//        public void Roots_SmallCoefficients_RootsSatisfyEquation()
//        {
//            // x³ + 0.001x² + 0.001x + 0.001 = 0
//            double a = 1, b = 0.001, c = 0.001, d = 0.001;
//            var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//            // Verify roots satisfy equation
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root1, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root2, a, b, c, d)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluateCubic(root3, a, b, c, d)) < Precision);
//        }

//        //[TestMethod]
//        //public void Roots_LargeCoefficients_RootsSatisfyEquation()
//        //{
//        //    // x³ + 1000x² + 1000x + 1000 = 0
//        //    double a = 1, b = 1000, c = 1000, d = 1000;
//        //    var (root1, root2, root3) = Cubic.Roots(d, c, b, a);

//        //    // Verify roots satisfy equation
//        //    Assert.IsTrue(Complex.Abs(EvaluateCubic(root1, a, b, c, d)) < Precision);
//        //    Assert.IsTrue(Complex.Abs(EvaluateCubic(root2, a, b, c, d)) < Precision);
//        //    Assert.IsTrue(Complex.Abs(EvaluateCubic(root3, a, b, c, d)) < Precision);
//        //}
//    }
//}
