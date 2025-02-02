//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;
//using System;

//namespace FluentValidationTests {

//	[TestClass]
//	public class LengthValidatorTests {

//		private class TestContext {
//			public string PropertyToValidate { get; set; }
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnTrue_WhenValueIsNull() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(5, 10);
//			var context = new ValidationContext<TestContext>(new TestContext());

//			// Act
//			var result = validator.IsValid(context, null);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnTrue_WhenValueWithinRange() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(5, 10);
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "Valid"; // Length is 5

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnFalse_WhenValueBelowMinLength() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(5, 10);
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "Tiny"; // Length is 4

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnFalse_WhenValueExceedsMaxLength() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(5, 10);
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "ThisIsWayTooLong"; // Length is 16

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_ShouldThrowException_WhenMaxLessThanMin() {
//			// Act
//			var validator = new LengthValidator<TestContext>(10, 5);
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnTrue_WithDynamicMinMax_WithinRange() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(
//					ctx => 3,
//					ctx => 7
//			);
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "Hello"; // Length is 5

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_ShouldReturnFalse_WithDynamicMinMax_ExceedsRange() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(
//					ctx => 3,
//					ctx => 7
//			);
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "ExceedsRange"; // Length is 12

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_ShouldHandleUnboundedMax() {
//			// Arrange
//			var validator = new LengthValidator<TestContext>(5, -1); // No upper limit
//			var context = new ValidationContext<TestContext>(new TestContext());
//			string value = "ThisIsFine"; // Length is 10

//			// Act
//			var result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}
//	}
//}
