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
//            // x³ + 0x² - 4x + 0 = 0
//            // Roots are 0, 2, -2
//            var (root1, root2, root3) = Cubic.Roots(0, -4, 0, 1);

//            // Sort roots to ensure consistent ordering
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Real.CompareTo(y.Real));

//            Assert.AreEqual(-2.0, roots[0].Real, Precision);
//            Assert.AreEqual(0.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(2.0, roots[2].Real, Precision);
//            Assert.AreEqual(0.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_TripleRoot_ReturnsThreeEqualValues()
//        {
//            // (x - 1)³ = x³ - 3x² + 3x - 1
//            var (root1, root2, root3) = Cubic.Roots(-1, 3, -3, 1);

//            Assert.AreEqual(1.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(1.0, root2.Real, Precision);
//            Assert.AreEqual(0.0, root2.Imaginary, Precision);
//            Assert.AreEqual(1.0, root3.Real, Precision);
//            Assert.AreEqual(0.0, root3.Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_OneRealTwoComplex_ReturnsCorrectValues()
//        {
//            // x³ - x = 0
//            // Has roots 0, +1i, -1i
//            var (root1, root2, root3) = Cubic.Roots(0, -1, 0, 1);

//            // Sort roots by imaginary part to ensure consistent ordering
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Imaginary.CompareTo(y.Imaginary));

//            Assert.AreEqual(0.0, roots[0].Real, Precision);
//            Assert.AreEqual(-1.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[2].Real, Precision);
//            Assert.AreEqual(1.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_DoubleRootPlusReal_ReturnsCorrectValues()
//        {
//            // (x - 1)²(x + 2) = x³ - 3x - 2
//            var (root1, root2, root3) = Cubic.Roots(-2, 0, -3, 1);

//            // Sort roots by real part
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Real.CompareTo(y.Real));

//            Assert.AreEqual(-2.0, roots[0].Real, Precision);
//            Assert.AreEqual(0.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(1.0, roots[1].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(1.0, roots[2].Real, Precision);
//            Assert.AreEqual(0.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void Roots_ZeroLeadingCoefficient_ThrowsDivideByZeroException()
//        {
//            // When a = 0, the equation is not cubic and should throw
//            _ = Cubic.Roots(1, 2, 3, 0);
//        }

//        [TestMethod]
//        public void Roots_SmallCoefficients_ReturnsValidResults()
//        {
//            // x³ + 0.001x² + 0.001x + 0.001 = 0
//            var (root1, root2, root3) = Cubic.Roots(0.001, 0.001, 0.001, 1);

//            // Verify roots satisfy the equation approximately
//            Complex EvaluateAtRoot(Complex root)
//            {
//                return root * root * root + 0.001 * root * root + 0.001 * root + 0.001;
//            }

//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root1)) < 1e-10);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root2)) < 1e-10);
//            Assert.IsTrue(Complex.Abs(EvaluateAtRoot(root3)) < 1e-10);
//        }

//        [TestMethod]
//        public void Roots_VerifyRootsAreDistinct_WhenExpected()
//        {
//            // x³ - 6x = 0
//            // Roots are 0, ?6, -?6
//            var (root1, root2, root3) = Cubic.Roots(0, -6, 0, 1);

//            // Sort roots by real part
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Real.CompareTo(y.Real));

//            // Verify roots are different
//            Assert.AreNotEqual(roots[0], roots[1], "First and second roots should be different");
//            Assert.AreNotEqual(roots[1], roots[2], "Second and third roots should be different");
//            Assert.AreNotEqual(roots[0], roots[2], "First and third roots should be different");

//            // Verify approximate values
//            Assert.AreEqual(-Math.Sqrt(6), roots[0].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(Math.Sqrt(6), roots[2].Real, Precision);
//        }
//    }
//}
