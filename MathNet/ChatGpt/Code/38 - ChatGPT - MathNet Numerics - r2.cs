//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Numerics;
//using MathNet.Numerics.RootFinding;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class CubicTests
//    {
//        [TestMethod]
//        public void Roots_TypicalCase_RealRoots()
//        {
//            // Arrange
//            double d = -6;
//            double c = 11;
//            double b = -6;
//            double a = 1;

//            // Act
//            var roots = Cubic.Roots(d, c, b, a);

//            // Assert
//            Assert.AreEqual(1.0, roots.Item1.Real, 1e-6);
//            Assert.AreEqual(2.0, roots.Item2.Real, 1e-6);
//            Assert.AreEqual(3.0, roots.Item3.Real, 1e-6);
//        }

//        [TestMethod]
//        public void Roots_TypicalCase_ComplexRoots()
//        {
//            // Arrange
//            double d = 2;
//            double c = -4;
//            double b = 2;
//            double a = 1;

//            // Act
//            var roots = Cubic.Roots(d, c, b, a);

//            // Assert
//            Assert.IsTrue(roots.Item1.Imaginary != 0 || roots.Item2.Imaginary != 0 || roots.Item3.Imaginary != 0);
//        }

//        [TestMethod]
//        public void Roots_EdgeCase_AllZeroCoefficients()
//        {
//            // Arrange
//            double d = 0;
//            double c = 0;
//            double b = 0;
//            double a = 0;

//            // Act
//            try
//            {
//                var roots = Cubic.Roots(d, c, b, a);
//                Assert.Fail("Expected an exception but none was thrown.");
//            }
//            catch (DivideByZeroException)
//            {
//                Assert.IsTrue(true);
//            }
//        }

//        [TestMethod]
//        public void Roots_EdgeCase_DegenerateCubic_AIsZero()
//        {
//            // Arrange
//            double d = 1;
//            double c = -6;
//            double b = 11;
//            double a = 0; // Linear equation

//            // Act
//            try
//            {
//                var roots = Cubic.Roots(d, c, b, a);
//                Assert.Fail("Expected an exception but none was thrown.");
//            }
//            catch (DivideByZeroException)
//            {
//                Assert.IsTrue(true);
//            }
//        }

//        [TestMethod]
//        public void Roots_EdgeCase_TripleRoot()
//        {
//            // Arrange
//            double d = -8;
//            double c = 12;
//            double b = -6;
//            double a = 1;

//            // Act
//            var roots = Cubic.Roots(d, c, b, a);

//            // Assert
//            Assert.AreEqual(2.0, roots.Item1.Real, 1e-6);
//            Assert.AreEqual(2.0, roots.Item2.Real, 1e-6);
//            Assert.AreEqual(2.0, roots.Item3.Real, 1e-6);
//        }

//        [TestMethod]
//        public void Roots_ValidCase_DoubleRootAndDistinctRoot()
//        {
//            // Arrange
//            double d = 4;
//            double c = -10;
//            double b = 8;
//            double a = 1;

//            // Act
//            var roots = Cubic.Roots(d, c, b, a);

//            // Assert
//            Assert.AreEqual(2.0, roots.Item1.Real, 1e-6);
//            Assert.AreEqual(2.0, roots.Item2.Real, 1e-6);
//            Assert.AreEqual(1.0, roots.Item3.Real, 1e-6);
//        }
//    }
//}
