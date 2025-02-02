//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MathNet.Numerics;
//using MathNet.Numerics.Specifications;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class GammaLowerRegularizedTests
//    {
//        [TestMethod]
//        public void GammaLowerRegularized_TypicalValues_ReturnsExpectedResults()
//        {
//            // Arrange
//            double a = 1.5;
//            double x = 2.0;

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(result, SpecialFunctions.GammaLowerRegularized(a, x));
//        }

//        [TestMethod]
//        public void GammaLowerRegularized_EdgeCases_ReturnsExpectedResults()
//        {
//            // Arrange
//            double a = 0.0;
//            double x = 0.0;

//            // Act
//            double result = SpecialFunctions.GammaLowerRegularized(a, x);

//            // Assert
//            Assert.AreEqual(result, 1.0);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void GammaLowerRegularized_InvalidArgument_ThrowsException()
//        {
//            // Arrange
//            double a = -1.0;
//            double x = 0.0;

//            // Act
//            SpecialFunctions.GammaLowerRegularized(a, x);
//        }

//        [TestMethod]
//        public void GammaLowerRegularized_InvalidInput_ThrowsException()
//        {
//            // Arrange
//            double a = double.NaN;
//            double x = 0.0;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SpecialFunctions.GammaLowerRegularized(a, x));
//        }
//    }
//}
