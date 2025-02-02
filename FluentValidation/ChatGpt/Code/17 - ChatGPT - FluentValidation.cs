//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Validators;
//using System;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {

//		[TestMethod]
//		public void Constructor_ValidScaleAndPrecision_ShouldInitializeSuccessfully() {
//			// Arrange
//			int scale = 2;
//			int precision = 5;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);

//			// Assert
//			Assert.AreEqual(scale, validator.Scale);
//			Assert.AreEqual(precision, validator.Precision);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_NegativeScale_ShouldThrowArgumentOutOfRangeException() {
//			// Arrange
//			int scale = -1;
//			int precision = 5;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_NegativePrecision_ShouldThrowArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 2;
//			int precision = -1;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_ScaleGreaterThanPrecision_ShouldThrowArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 6;
//			int precision = 5;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);
//		}

//		[TestMethod]
//		public void Constructor_ScaleEqualToPrecision_ShouldInitializeSuccessfully() {
//			// Arrange
//			int scale = 5;
//			int precision = 5;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);

//			// Assert
//			Assert.AreEqual(scale, validator.Scale);
//			Assert.AreEqual(precision, validator.Precision);
//		}

//		[TestMethod]
//		public void Constructor_ZeroScaleAndPrecision_ShouldInitializeSuccessfully() {
//			// Arrange
//			int scale = 0;
//			int precision = 0;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);

//			// Assert
//			Assert.AreEqual(scale, validator.Scale);
//			Assert.AreEqual(precision, validator.Precision);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_ScaleZeroPrecisionNegative_ShouldThrowArgumentOutOfRangeException() {
//			// Arrange
//			int scale = 0;
//			int precision = -1;

//			// Act
//			var validator = new ScalePrecisionValidator<object>(scale, precision);
//		}
//	}
//}
