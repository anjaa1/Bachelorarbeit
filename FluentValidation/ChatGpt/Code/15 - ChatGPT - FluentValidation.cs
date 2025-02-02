//using System;
//using FluentValidation.Validators;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace ScalePrecisionValidatorTests {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {
//		[TestMethod]
//		public void IsValid_ValidDecimalWithinScaleAndPrecision_ReturnsTrue() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 2, precision: 5);
//			var decimalValue = 123.45m;

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsTrue(isValid, "Expected the method to return true for a valid decimal value within scale and precision.");
//		}

//		[TestMethod]
//		public void IsValid_DecimalExceedsScale_ReturnsFalse() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 2, precision: 5);
//			var decimalValue = 123.456m; // Scale exceeds 2

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsFalse(isValid, "Expected the method to return false for a decimal value exceeding the scale.");
//		}

//		[TestMethod]
//		public void IsValid_DecimalExceedsPrecision_ReturnsFalse() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 2, precision: 5);
//			var decimalValue = 12345.67m; // Precision exceeds 5

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsFalse(isValid, "Expected the method to return false for a decimal value exceeding the precision.");
//		}

//		[TestMethod]
//		public void IsValid_DecimalWithTrailingZeros_ReturnsTrueWhenIgnoreTrailingZerosIsTrue() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 2, precision: 5) {
//				IgnoreTrailingZeros = true
//			};
//			var decimalValue = 123.4500m; // Effective scale: 2, Effective precision: 5

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsTrue(isValid, "Expected the method to return true for a decimal value with trailing zeros when IgnoreTrailingZeros is true.");
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_InvalidScale_ThrowsArgumentOutOfRangeException() {
//			// Act
//			new ScalePrecisionValidator<object>(scale: -1, precision: 5);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_ScaleGreaterThanPrecision_ThrowsArgumentOutOfRangeException() {
//			// Act
//			new ScalePrecisionValidator<object>(scale: 6, precision: 5);
//		}

//		[TestMethod]
//		public void IsValid_DecimalEqualsScaleAndPrecisionBoundaries_ReturnsTrue() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 2, precision: 5);
//			var decimalValue = 12.34m; // Scale: 2, Precision: 4

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsTrue(isValid, "Expected the method to return true for a decimal value exactly on scale and precision boundaries.");
//		}

//		[TestMethod]
//		public void IsValid_DecimalWithZerosOnlyInScale_ReturnsTrue() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<object>(scale: 3, precision: 5);
//			var decimalValue = 0.123m; // Precision: 3, Scale: 3

//			// Act
//			var isValid = validator.IsValid(null, decimalValue);

//			// Assert
//			Assert.IsTrue(isValid, "Expected the method to return true for a decimal value with zeros only in scale.");
//		}
//	}
//}
