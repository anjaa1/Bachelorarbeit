//using FluentValidation.TestHelper;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using FluentValidation.Validators; // Added this line

//namespace FluentValidation.Tests.Validators;

//[TestClass]
//public class ScalePrecisionValidatorTests {
//	[TestMethod]
//	public void IsValid_ValidNumber_ReturnsTrue() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.45m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldNotHaveAnyValidationErrors();
//	}

//	[TestMethod]
//	public void IsValid_InvalidNumber_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4567m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithMoreIntegerDigitsThanAllowed_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 12345m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithMoreDecimalDigitsThanAllowed_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4567m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZeros_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4500m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithMoreIntegerDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 1234567m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.456789m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndMoreIntegerDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 12345000m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4500789m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndMoreIntegerDigitsThanPrecisionAndMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 12345000.12345678m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndMoreIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 12345000.123m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4500789m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.450m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecisionAndMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.45078m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecisionAndLessIntegerDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.45m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecisionAndMoreDecimalDigitsThanPrecisionAndMoreIntegerDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.4500789m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecisionAndLessIntegerDigitsThanPrecisionAndMoreDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.45078m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	[TestMethod]
//	public void IsValid_NumberWithTrailingZerosAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecisionAndLessIntegerDigitsThanPrecisionAndLessDecimalDigitsThanPrecision_ReturnsFalse() {
//		// Arrange
//		var validator = new ScalePrecisionValidator<int>(2, 5);
//		var model = new Model { Value = 123.45m };

//		// Act
//		var result = validator.TestValidate(model);

//		// Assert
//		result.ShouldHaveValidationErrorFor(x => x.Value);
//	}

//	public class Model {
//		public decimal Value { get; set; }
//	}
//}
