//using FluentValidation;
//using FluentValidation.TestHelper;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace FluentValidation.Tests.Validators;

//[TestClass]
//public class LengthValidatorTests {

//	[TestMethod]
//	public void IsValid_ValidInput_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, 10);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello World";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_InvalidInput_ReturnsFalse() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, 10);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsFalse(result);
//	}

//	[TestMethod]
//	public void IsValid_NullInput_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, 10);
//		var context = new ValidationContext<int>(10);
//		var value = null;

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_MinAndMaxFuncs_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(i => i, i => i);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello World";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_MinAndMaxFuncs_InvalidInput_ReturnsFalse() {
//		// Arrange
//		var validator = new LengthValidator<int>(i => i, i => i);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsFalse(result);
//	}

//	[TestMethod]
//	public void IsValid_MinAndMaxFuncs_NullInput_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(i => i, i => i);
//		var context = new ValidationContext<int>(10);
//		var value = null;

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_MaxIsMinusOne_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, -1);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello World";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_MaxIsMinusOne_InvalidInput_ReturnsFalse() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, -1);
//		var context = new ValidationContext<int>(10);
//		var value = "Hello";

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsFalse(result);
//	}

//	[TestMethod]
//	public void IsValid_MaxIsMinusOne_NullInput_ReturnsTrue() {
//		// Arrange
//		var validator = new LengthValidator<int>(1, -1);
//		var context = new ValidationContext<int>(10);
//		var value = null;

//		// Act
//		var result = validator.IsValid(context, value);

//		// Assert
//		Assert.IsTrue(result);
//	}

//	[TestMethod]
//	public void IsValid_MaxIsLessThanMin_ThrowsException() {
//		// Arrange
//		var validator = new LengthValidator<int>(10, 5);

//		// Act and Assert
//		Assert.ThrowsException<ArgumentOutOfRangeException>(() => validator.IsValid(new ValidationContext<int>(10), "Hello"));
//	}
//}
