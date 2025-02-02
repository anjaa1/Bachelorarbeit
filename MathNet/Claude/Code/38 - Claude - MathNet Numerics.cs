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

//        [TestMethod]
//        public void Roots_SimpleRealRoots_ReturnsCorrectValues()
//        {
//            // x³ - 6x² + 11x - 6 = 0
//            // Roots are 1, 2, and 3
//            var (root1, root2, root3) = Cubic.Roots(-6, 11, -6, 1);

//            Assert.AreEqual(1.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(2.0, root2.Real, Precision);
//            Assert.AreEqual(0.0, root2.Imaginary, Precision);
//            Assert.AreEqual(3.0, root3.Real, Precision);
//            Assert.AreEqual(0.0, root3.Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_TripleRoot_ReturnsThreeEqualValues()
//        {
//            // (x - 2)³ = x³ - 6x² + 12x - 8
//            var (root1, root2, root3) = Cubic.Roots(-8, 12, -6, 1);

//            Assert.AreEqual(2.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(root1, root2);
//            Assert.AreEqual(root2, root3);
//        }

//        [TestMethod]
//        public void Roots_OneRealTwoComplex_ReturnsCorrectValues()
//        {
//            // x³ + x = 0
//            // Has roots 0 and ±i
//            var (root1, root2, root3) = Cubic.Roots(0, 1, 0, 1);

//            // Sort roots by real part to ensure consistent ordering
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Real.CompareTo(y.Real));

//            Assert.AreEqual(-1.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(1.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_ZeroCoefficients_ReturnsValidResults()
//        {
//            // x³ = 0
//            var (root1, root2, root3) = Cubic.Roots(0, 0, 0, 1);

//            Assert.AreEqual(0.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(root1, root2);
//            Assert.AreEqual(root2, root3);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void Roots_ZeroLeadingCoefficient_ThrowsException()
//        {
//            // This should throw because a=0 makes it not a cubic equation
//            Cubic.Roots(1, 1, 1, 0);
//        }

//        [TestMethod]
//        public void Roots_LargeCoefficients_ReturnsValidResults()
//        {
//            // Test with large coefficients to check numerical stability
//            var (root1, root2, root3) = Cubic.Roots(1e6, 1e6, 1e6, 1);

//            // Verify roots satisfy the equation approximately
//            Complex EvaluateAtRoot(Complex root)
//            {
//                return root * root * root + 1e6 * root * root + 1e6 * root + 1e6;
//            }

//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root1)) < 1e-3);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root2)) < 1e-3);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root3)) < 1e-3);
//        }

//        [TestMethod]
//        public void Roots_SmallCoefficients_ReturnsValidResults()
//        {
//            // Test with small coefficients to check numerical stability
//            var (root1, root2, root3) = Cubic.Roots(1e-6, 1e-6, 1e-6, 1);

//            // Verify roots satisfy the equation approximately
//            Complex EvaluateAtRoot(Complex root)
//            {
//                return root * root * root + 1e-6 * root * root + 1e-6 * root + 1e-6;
//            }

//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root1)) < 1e-10);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root2)) < 1e-10);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root3)) < 1e-10);
//        }
//    }
//}
