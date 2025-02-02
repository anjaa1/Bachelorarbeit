//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;
//using System;

//namespace CreditCardValidatorTests {
//	[TestClass]
//	public class CreditCardValidatorTests {
//		private CreditCardValidator<object> _validator;

//		[TestInitialize]
//		public void Setup() {
//			_validator = new CreditCardValidator<object>();
//		}

//		[TestMethod]
//		public void IsValid_WithNonDigitCharacters_ReturnsFalse() {
//			// Arrange
//			string invalidCardNumber = "4111-1111-1111-111X"; // Contains invalid character 'X'
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, invalidCardNumber);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithValidCreditCardNumber_ReturnsTrue() {
//			// Arrange
//			string validCardNumber = "4111111111111111"; // Example Visa card number
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, validCardNumber);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithInvalidCreditCardNumber_ReturnsFalse() {
//			// Arrange
//			string invalidCardNumber = "4111111111111112"; // Invalid checksum
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, invalidCardNumber);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithNullValue_ReturnsTrue() {
//			// Arrange
//			string nullValue = null;
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, nullValue);

//			// Assert
//			Assert.IsTrue(result);
//		}



//		[TestMethod]
//		public void IsValid_WithSpacesAndDashesInValidCardNumber_ReturnsTrue() {
//			// Arrange
//			string validCardNumber = "4111-1111-1111-1111"; // Dashes included
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, validCardNumber);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithEmptyString_ReturnsTrue() {
//			// Arrange
//			string emptyString = "";
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, emptyString);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithWhitespaceOnly_ReturnsTrue() {
//			// Arrange
//			string whitespaceOnly = "   ";
//			var context = new ValidationContext<object>(new object());

//			// Act
//			bool result = _validator.IsValid(context, whitespaceOnly);

//			// Assert
//			Assert.IsTrue(result);

//		}
//	}

//}


