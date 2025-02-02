//using System;
//using System.Collections;
//using System.Collections.Generic;
//using FluentValidation;
//using FluentValidation.Validators;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidationTests {

//	[TestClass]
//	public class EmptyValidatorTests {

//		private class TestContext<T> : ValidationContext<T> {
//			public TestContext(T instanceToValidate) : base(instanceToValidate) { }
//		}

//		private EmptyValidator<object, object> _validator;

//		[TestInitialize]
//		public void Setup() {
//			_validator = new EmptyValidator<object, object>();
//		}

//		[TestMethod]
//		public void IsValid_NullValue_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>(null);

//			// Act
//			var result = _validator.IsValid(context, null);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyString_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>(string.Empty);

//			// Act
//			var result = _validator.IsValid(context, string.Empty);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WhitespaceString_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>("   ");

//			// Act
//			var result = _validator.IsValid(context, "   ");

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyCollection_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>(new List<int>());

//			// Act
//			var result = _validator.IsValid(context, new List<int>());

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonEmptyCollection_ReturnsFalse() {
//			// Arrange
//			var context = new TestContext<object>(new List<int> { 1 });

//			// Act
//			var result = _validator.IsValid(context, new List<int> { 1 });

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyEnumerable_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>(new int[0]);

//			// Act
//			var result = _validator.IsValid(context, new int[0]);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_DefaultValue_ReturnsTrue() {
//			// Arrange
//			var context = new TestContext<object>(default(int));

//			// Act
//			var result = _validator.IsValid(context, default(int));

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonDefaultValue_ReturnsFalse() {
//			// Arrange
//			var context = new TestContext<object>(42);

//			// Act
//			var result = _validator.IsValid(context, 42);

//			// Assert
//			Assert.IsFalse(result);
//		}
//	}
//}
