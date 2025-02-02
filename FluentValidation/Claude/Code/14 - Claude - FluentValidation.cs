//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;
//using System.Collections.Generic;

//namespace FluentValidation.Tests.Validators {
//	[TestClass]
//	public class EmptyValidatorTests {
//		private EmptyValidator<TestModel, object> validator;
//		private TestModel testModel;

//		[TestInitialize]
//		public void Setup() {
//			validator = new EmptyValidator<TestModel, object>();
//			testModel = new TestModel();
//		}

//		[TestMethod]
//		public void IsValid_EmptyList_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			var value = new List<string>();

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NullValue_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			object value = null;

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyString_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			string value = string.Empty;

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WhitespaceString_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			string value = "   ";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonEmptyString_ReturnsFalse() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			string value = "test";

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}



//		[TestMethod]
//		public void IsValid_NonEmptyList_ReturnsFalse() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			var value = new List<string> { "item" };

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyArray_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			var value = new string[0];

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonEmptyArray_ReturnsFalse() {
//			// Arrange
//			var context = new ValidationContext<TestModel>(testModel);
//			var value = new[] { "item" };

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_DefaultValueType_ReturnsTrue() {
//			// Arrange
//			var validator = new EmptyValidator<TestModel, int>();
//			var context = new ValidationContext<TestModel>(testModel);
//			int value = 0; // default value for int

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonDefaultValueType_ReturnsFalse() {
//			// Arrange
//			var validator = new EmptyValidator<TestModel, int>();
//			var context = new ValidationContext<TestModel>(testModel);
//			int value = 42;

//			// Act
//			bool result = validator.IsValid(context, value);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		// Helper class for testing
//		private class TestModel { }
//	}
//}
