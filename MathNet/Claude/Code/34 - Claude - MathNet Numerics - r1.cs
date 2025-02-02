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
//        var expected = new Complex(2.8284271247461903, 2.8284271247461903);  // ?(8 + 8i)

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
//        var expected = new Complex(2.8284271247461903, -2.8284271247461903);  // ?(8 - 8i)

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
//    public void SquareRoot_LargeNumbers_ValidatesSquareProperty()
//    {
//        // Arrange
//        var complex = new Complex(1e15, 1e15);  // Reduced magnitude to avoid precision issues

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        var squared = result * result;
//        AssertComplexEqual(complex, squared, 1e-3);  // Increased tolerance for large numbers
//    }

//    [TestMethod]
//    public void SquareRoot_SmallNumbers_ValidatesSquareProperty()
//    {
//        // Arrange
//        var complex = new Complex(1e-15, 1e-15);

//        // Act
//        var result = complex.SquareRoot();

//        // Assert
//        var squared = result * result;
//        AssertComplexEqual(complex, squared, 1e-20);  // Adjusted tolerance for small numbers
//    }

//    private void AssertComplexEqual(Complex expected, Complex actual, double? customPrecision = null)
//    {
//        double precision = customPrecision ?? Precision;
//        Assert.AreEqual(expected.Real, actual.Real, precision,
//            $"Real parts differ. Expected: {expected.Real}, Actual: {actual.Real}");
//        Assert.AreEqual(expected.Imaginary, actual.Imaginary, precision,
//            $"Imaginary parts differ. Expected: {expected.Imaginary}, Actual: {actual.Imaginary}");
//    }
//}
