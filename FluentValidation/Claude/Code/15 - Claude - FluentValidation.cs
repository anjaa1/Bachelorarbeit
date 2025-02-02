//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;

//namespace FluentValidation.Tests.Validators {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {
//		private ValidationContext<TestModel> context;
//		private TestModel model;

//		[TestInitialize]
//		public void Setup() {
//			model = new TestModel();
//			context = new ValidationContext<TestModel>(model);
//		}

//		[TestClass]
//		public class StandardValidation {
//			[TestMethod]
//			public void WhenValueIsWithinPrecisionAndScale_ShouldBeValid() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5); // 5 total digits, 2 decimal places
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, 123.45m));  // 3 digits left, 2 right
//				Assert.IsTrue(validator.IsValid(context, 1.23m));    // Less digits than max
//				Assert.IsTrue(validator.IsValid(context, 0.12m));    // Leading zero
//			}

//			[TestMethod]
//			public void WhenScaleExceedsLimit_ShouldBeInvalid() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsFalse(validator.IsValid(context, 123.456m));  // 3 decimal places > 2 allowed
//				Assert.IsFalse(validator.IsValid(context, 1.234m));    // 3 decimal places > 2 allowed
//			}

//			[TestMethod]
//			public void WhenPrecisionExceedsLimit_ShouldBeInvalid() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsFalse(validator.IsValid(context, 1234.56m));  // 6 total digits > 5 allowed
//				Assert.IsFalse(validator.IsValid(context, 999.99m));   // Edge case at limit
//			}
//		}

//		[TestClass]
//		public class TrailingZeros {
//			[TestMethod]
//			public void WhenIgnoreTrailingZerosIsTrue_ShouldConsiderEffectiveScale() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5) {
//					IgnoreTrailingZeros = true
//				};
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, 123.40m));    // Effectively one decimal place
//				Assert.IsTrue(validator.IsValid(context, 123.00m));    // Effectively no decimal places
//			}

//			[TestMethod]
//			public void WhenIgnoreTrailingZerosIsFalse_ShouldConsiderAllZeros() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5) {
//					IgnoreTrailingZeros = false
//				};
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, 123.40m));     // Two decimal places
//				Assert.IsFalse(validator.IsValid(context, 1234.00m));   // Exceeds precision
//			}
//		}

//		[TestClass]
//		public class EdgeCases {
//			[TestMethod]
//			public void WhenValueIsZero_ShouldBeValid() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, 0.00m));
//				Assert.IsTrue(validator.IsValid(context, 0m));
//			}

//			[TestMethod]
//			public void WhenValueHasMaximumAllowedDigits_ShouldBeValid() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, 999.99m));    // Exactly 5 digits with 2 decimal places
//			}

//			[TestMethod]
//			public void WhenValueIsNegative_ShouldValidateTheSameAsPositive() {
//				// Arrange
//				var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//				var context = new ValidationContext<TestModel>(new TestModel());

//				// Act & Assert
//				Assert.IsTrue(validator.IsValid(context, -123.45m));    // Valid negative number
//				Assert.IsFalse(validator.IsValid(context, -1234.56m));  // Invalid negative number
//			}
//		}

//		private class TestModel { }
//	}
//}
