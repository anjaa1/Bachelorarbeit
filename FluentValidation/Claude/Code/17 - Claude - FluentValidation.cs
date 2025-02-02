//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Validators;
//using System;

//namespace FluentValidation.Tests.Validators {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {
//		[TestMethod]
//		public void Constructor_WithValidScaleAndPrecision_SetsProperties() {
//			// Arrange & Act
//			var validator = new ScalePrecisionValidator<object>(2, 5);

//			// Assert
//			Assert.AreEqual(2, validator.Scale);
//			Assert.AreEqual(5, validator.Precision);
//			Assert.IsFalse(validator.IgnoreTrailingZeros);
//		}

//		[TestMethod]
//		[DataRow(0, 1)]    // Minimum valid values
//		[DataRow(2, 5)]    // Typical values
//		[DataRow(4, 4)]    // Equal scale and precision
//		[DataRow(0, 10)]   // Zero scale
//		public void Constructor_WithValidInputs_DoesNotThrowException(int scale, int precision) {
//			// Act & Assert
//			var exception = Record.Exception(() => new ScalePrecisionValidator<object>(scale, precision));
//			Assert.IsNull(exception);
//		}

//		[TestMethod]
//		[DataRow(-1, 5, "scale")]          // Negative scale
//		[DataRow(2, -1, "precision")]      // Negative precision
//		public void Constructor_WithNegativeValues_ThrowsArgumentOutOfRangeException(
//				int scale,
//				int precision,
//				string paramName) {
//			// Act & Assert
//			var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(
//					() => new ScalePrecisionValidator<object>(scale, precision)
//			);

//			Assert.AreEqual(paramName, exception.ParamName);
//			Assert.IsTrue(exception.Message.Contains("must be a positive integer"));
//		}

//		[TestMethod]
//		[DataRow(5, 3)]    // Scale greater than precision
//		[DataRow(10, 5)]   // Scale much larger than precision
//		public void Constructor_WithScaleGreaterThanPrecision_ThrowsArgumentOutOfRangeException(
//				int scale,
//				int precision) {
//			// Act & Assert
//			var exception = Assert.ThrowsException<ArgumentOutOfRangeException>(
//					() => new ScalePrecisionValidator<object>(scale, precision)
//			);

//			Assert.AreEqual("scale", exception.ParamName);
//			Assert.IsTrue(exception.Message.Contains("Scale must be less than precision"));
//		}

//		[TestMethod]
//		public void Constructor_WithMaxValues_DoesNotThrowException() {
//			// Arrange
//			const int maxValue = int.MaxValue;

//			// Act & Assert
//			var exception = Record.Exception(() =>
//					new ScalePrecisionValidator<object>(maxValue - 1, maxValue));
//			Assert.IsNull(exception);
//		}
//	}
//}
