//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Numerics;
//using MathNet.Numerics;

//[TestClass]
//public class ComplexExtensionsTests
//{
//    private const double Precision = 1e-12;

//    [TestMethod]
//    public void SquareRoot_RealNonNegativeNumber_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(16.0, 0.0);
//        var expected = new Complex(4.0, 0.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_RealNegativeNumber_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(-16.0, 0.0);
//        var expected = new Complex(0.0, 4.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_PureImaginaryNumber_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(0.0, 16.0);
//        var expected = new Complex(2.0, 4.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_NegativeImaginaryNumber_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(0.0, -16.0);
//        var expected = new Complex(2.0, -4.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_ComplexNumber_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(3.0, 4.0);
//        var expected = new Complex(2.0, 1.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_Zero_ReturnsZero()
//    {
//        // Arrange
//        var complex = new Complex(0.0, 0.0);
//        var expected = new Complex(0.0, 0.0);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        AssertComplexEqual(expected, result);
//    }

//    [TestMethod]
//    public void SquareRoot_LargeNumbers_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(1e150, 1e150);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        // Verify that (result * result) equals the original number
//        var squared = result * result;
//        AssertComplexEqual(complex, squared);
//    }

//    [TestMethod]
//    public void SquareRoot_SmallNumbers_ReturnsCorrectResult()
//    {
//        // Arrange
//        var complex = new Complex(1e-150, 1e-150);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        // Verify that (result * result) equals the original number
//        var squared = result * result;
//        AssertComplexEqual(complex, squared);
//    }

//    private void AssertComplexEqual(Complex expected, Complex actual)
//    {
//        Assert.AreEqual(expected.Real, actual.Real, Precision,
//            $"Real parts differ. Expected: {expected.Real}, Actual: {actual.Real}");
//        Assert.AreEqual(expected.Imaginary, actual.Imaginary, Precision,
//            $"Imaginary parts differ. Expected: {expected.Imaginary}, Actual: {actual.Imaginary}");
//    }
//}
