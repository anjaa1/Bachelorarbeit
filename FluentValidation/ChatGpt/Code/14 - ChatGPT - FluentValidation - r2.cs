//using System;
//using System.Collections;
//using System.Collections.Generic;
//using FluentValidation;
//using FluentValidation.Validators;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidationTests {

//	[TestClass]
//	public class EmptyValidatorTests {

//		private EmptyValidator<object, object> _validator;

//		[TestInitialize]
//		public void Setup() {
//			_validator = new EmptyValidator<object, object>();
//		}

//		[TestMethod]
//		public void IsValid_NullValue_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());

//			// Act
//			var result = _validator.IsValid(context, null);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyString_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());

//			// Act
//			var result = _validator.IsValid(context, string.Empty);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WhitespaceString_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());

//			// Act
//			var result = _validator.IsValid(context, "   ");

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyCollection_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());
//			var emptyCollection = new List<int>();

//			// Act
//			var result = _validator.IsValid(context, emptyCollection);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonEmptyCollection_ReturnsFalse() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());
//			var nonEmptyCollection = new List<int> { 1 };

//			// Act
//			var result = _validator.IsValid(context, nonEmptyCollection);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_EmptyEnumerable_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());
//			var emptyEnumerable = new int[0];

//			// Act
//			var result = _validator.IsValid(context, emptyEnumerable);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_DefaultValue_ReturnsTrue() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());

//			// Act
//			var result = _validator.IsValid(context, default(int));

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_NonDefaultValue_ReturnsFalse() {
//			// Arrange
//			var context = new ValidationContext<object>(new object());

//			// Act
//			var result = _validator.IsValid(context, 42);

//			// Assert
//			Assert.IsFalse(result);
//		}
//	}
//}
