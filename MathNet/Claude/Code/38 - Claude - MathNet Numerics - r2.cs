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
//            // x� - x = 0
//            // x(x� - 1) = 0
//            // Roots are -1, 0, 1
//            var (root1, root2, root3) = Cubic.Roots(0, -1, 0, 1);

//            // Sort roots by real part to ensure consistent ordering
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => x.Real.CompareTo(y.Real));

//            Assert.AreEqual(-1.0, roots[0].Real, Precision);
//            Assert.AreEqual(0.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(0.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(1.0, roots[2].Real, Precision);
//            Assert.AreEqual(0.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_TripleRoot_ReturnsThreeEqualValues()
//        {
//            // (x - 2)� = x� - 6x� + 12x - 8
//            var (root1, root2, root3) = Cubic.Roots(-8, 12, -6, 1);

//            Assert.AreEqual(2.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(2.0, root2.Real, Precision);
//            Assert.AreEqual(0.0, root2.Imaginary, Precision);
//            Assert.AreEqual(2.0, root3.Real, Precision);
//            Assert.AreEqual(0.0, root3.Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_OneRealTwoComplex_ReturnsCorrectValues()
//        {
//            // x� + x = 0
//            // x(x� + 1) = 0
//            // Has roots 0, i, -i
//            var (root1, root2, root3) = Cubic.Roots(0, 1, 0, 1);

//            // Sort roots first by real part, then by imaginary part
//            var roots = new[] { root1, root2, root3 };
//            Array.Sort(roots, (x, y) => {
//                int realComparison = x.Real.CompareTo(y.Real);
//                return realComparison != 0 ? realComparison : x.Imaginary.CompareTo(y.Imaginary);
//            });

//            Assert.AreEqual(0.0, roots[0].Real, Precision);
//            Assert.AreEqual(0.0, roots[0].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[1].Real, Precision);
//            Assert.AreEqual(-1.0, roots[1].Imaginary, Precision);
//            Assert.AreEqual(0.0, roots[2].Real, Precision);
//            Assert.AreEqual(1.0, roots[2].Imaginary, Precision);
//        }

//        [TestMethod]
//        public void Roots_DoubleRootPlusReal_ReturnsCorrectValues()
//        {
//            // (x - 1)�(x + 2) = x� + 0x� - x - 2
//            var (root1, root2, root3) = Cubic.Roots(-2, -1, 0, 1);

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
//        public void Roots_ZeroCoefficients_ReturnsExpectedValues()
//        {
//            // x� = 0
//            var (root1, root2, root3) = Cubic.Roots(0, 0, 0, 1);

//            Assert.AreEqual(0.0, root1.Real, Precision);
//            Assert.AreEqual(0.0, root1.Imaginary, Precision);
//            Assert.AreEqual(0.0, root2.Real, Precision);
//            Assert.AreEqual(0.0, root2.Imaginary, Precision);
//            Assert.AreEqual(0.0, root3.Real, Precision);
//            Assert.AreEqual(0.0, root3.Imaginary, Precision);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void Roots_ZeroLeadingCoefficient_ThrowsDivideByZeroException()
//        {
//            // When leading coefficient (a) is 0, should throw DivideByZeroException
//            Cubic.Roots(1, 1, 1, 0);
//        }

//        [TestMethod]
//        public void Roots_VerifyRootsSatisfyEquation()
//        {
//            // x� + 2x� + 3x + 4 = 0
//            var (root1, root2, root3) = Cubic.Roots(4, 3, 2, 1);

//            Complex EvaluatePolynomial(Complex x)
//            {
//                return x * x * x + 2 * x * x + 3 * x + 4;
//            }

//            Assert.IsTrue(Complex.Abs(EvaluatePolynomial(root1)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluatePolynomial(root2)) < Precision);
//            Assert.IsTrue(Complex.Abs(EvaluatePolynomial(root3)) < Precision);
//        }
//    }
//}
