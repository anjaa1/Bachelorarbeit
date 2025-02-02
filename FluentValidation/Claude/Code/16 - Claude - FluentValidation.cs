//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class LengthValidatorTests {
//		private ValidationContext<TestModel> context;
//		private TestModel testModel;

//		[TestInitialize]
//		public void Setup() {
//			testModel = new TestModel();
//			context = new ValidationContext<TestModel>(testModel);
//		}

//		[TestMethod]
//		public void IsValid_NullValue_ReturnsTrue() {
//			// Arrange
//			var validator = new LengthValidator<TestModel>(1, 10);

//			// Act
//			bool result = validator.IsValid(context, null);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_ValueWithinRange_ReturnsTrue() {
//			// Arrange
//			var validator = new LengthValidator<TestModel>(2, 5);
//			string value = "123";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_ValueTooShort_ReturnsFalse() {
//			// Arrange
//			var validator = new LengthValidator<TestModel>(5, 10);
//			string value = "123";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_ValueTooLong_ReturnsFalse() {
//			// Arrange
//			var validator = new LengthValidator<TestModel>(1, 3);
//			string value = "1234";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_MaxValueNegativeOne_AllowsAnyLength() {
//			// Arrange
//			var validator = new LengthValidator<TestModel>(1, -1);
//			string value = "ThisIsAVeryLongString";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentOutOfRangeException))]
//		public void Constructor_MaxLessThanMin_ThrowsException() {
//			// Act & Assert
//			_ = new LengthValidator<TestModel>(10, 5);
//		}

//		[TestMethod]
//		public void IsValid_WithDynamicRange_ValidatesCorrectly() {
//			// Arrange
//			testModel.MinLength = 2;
//			testModel.MaxLength = 5;
//			var validator = new LengthValidator<TestModel>(
//					min: model => model.MinLength,
//					max: model => model.MaxLength
//			);

//			// Act & Assert
//			Assert.IsTrue(validator.IsValid(context, "123")); // Valid
//			Assert.IsFalse(validator.IsValid(context, "1")); // Too short
//			Assert.IsFalse(validator.IsValid(context, "123456")); // Too long
//		}

//		// Helper class for testing
//		private class TestModel {
//			public int MinLength { get; set; }
//			public int MaxLength { get; set; }
//		}
//	}
//}
