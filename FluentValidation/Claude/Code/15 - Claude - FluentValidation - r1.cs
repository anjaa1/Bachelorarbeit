//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;

//namespace FluentValidation.Tests.Validators {
//	[TestClass]
//	public class ScalePrecisionValidatorTests {
//		private class TestModel { }

//		[TestMethod]
//		public void WhenValueWithinPrecisionAndScale_ShouldBeValid() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5); // 5 total digits, 2 decimal places
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 123.45 has precision 5 (total digits) and scale 2 (decimal places)
//			Assert.IsTrue(validator.IsValid(context, 123.45m));
//		}

//		[TestMethod]
//		public void WhenScaleExceedsLimit_ShouldBeInvalid() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 12.345 has scale 3, which exceeds allowed scale of 2
//			Assert.IsFalse(validator.IsValid(context, 12.345m));
//		}

//		[TestMethod]
//		public void WhenIntegerDigitsExceedLimit_ShouldBeInvalid() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 1234.5 has 4 integer digits, but with scale 2 and precision 5,
//			// only 3 integer digits are allowed (5-2=3)
//			Assert.IsFalse(validator.IsValid(context, 1234.5m));
//		}

//		[TestMethod]
//		public void WhenIgnoringTrailingZeros_ShouldValidateEffectiveScaleAndPrecision() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5) {
//				IgnoreTrailingZeros = true
//			};
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 123.400 has effective scale 0 and effective precision 3
//			Assert.IsTrue(validator.IsValid(context, 123.400m));
//		}

//		[TestMethod]
//		public void WhenNotIgnoringTrailingZeros_ShouldValidateActualScaleAndPrecision() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 12.300 has scale 3, which exceeds allowed scale of 2
//			Assert.IsFalse(validator.IsValid(context, 12.300m));
//		}

//		[TestMethod]
//		public void WhenZeroValue_ShouldBeValid() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			Assert.IsTrue(validator.IsValid(context, 0m));
//			Assert.IsTrue(validator.IsValid(context, 0.00m));
//		}

//		[TestMethod]
//		public void WhenNegativeValue_ShouldValidateTheSameAsPositive() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// -123.45 has precision 5 and scale 2
//			Assert.IsTrue(validator.IsValid(context, -123.45m));
//			// -1234.5 exceeds allowed integer digits
//			Assert.IsFalse(validator.IsValid(context, -1234.5m));
//		}

//		[TestMethod]
//		public void WhenAtPrecisionAndScaleLimits_ShouldBeValid() {
//			// Arrange
//			var validator = new ScalePrecisionValidator<TestModel>(2, 5);
//			var context = new ValidationContext<TestModel>(new TestModel());

//			// Act & Assert
//			// 123.45 is exactly at the limits (3 integer digits + 2 decimal digits = 5 total digits)
//			Assert.IsTrue(validator.IsValid(context, 123.45m));
//		}
//	}
//}
