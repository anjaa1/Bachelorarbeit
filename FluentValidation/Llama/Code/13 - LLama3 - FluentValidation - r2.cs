//using FluentValidation;
//using FluentValidation.TestHelper;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace FluentValidation.Tests.Validators {
//	[TestClass]
//	public class CreditCardValidatorTests {
//		[TestInitialize]
//		public void Initialize() {
//			Validator = new CreditCardValidator<string>();
//		}

//		private CreditCardValidator<string> Validator { get; set; }

//		[TestMethod]
//		public void IsValid_CreditCardNumber_ReturnsTrue() {
//			// Arrange
//			var validationContext = new ValidationContext<string>("1234567890123456");

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeTrue();
//		}

//		[TestMethod]
//		public void IsValid_InvalidCreditCardNumber_ReturnsFalse() {
//			// Arrange
//			var validationContext = new ValidationContext<string>("123456789012345");

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeFalse();
//		}

//		[TestMethod]
//		public void IsValid_NullValue_ReturnsTrue() {
//			// Arrange
//			var validationContext = new ValidationContext<string>(null);

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeTrue();
//		}

//		[TestMethod]
//		public void IsValid_EmptyString_ReturnsTrue() {
//			// Arrange
//			var validationContext = new ValidationContext<string>("");

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeTrue();
//		}

//		[TestMethod]
//		public void IsValid_InvalidFormat_ReturnsFalse() {
//			// Arrange
//			var validationContext = new ValidationContext<string>("123456789012345a");

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeFalse();
//		}

//		[TestMethod]
//		public void IsValid_Whitespace_ReturnsTrue() {
//			// Arrange
//			var validationContext = new ValidationContext<string>("1234 5678 9012 3456");

//			// Act
//			var result = Validator.IsValid(validationContext);

//			// Assert
//			result.Should().BeTrue();
//		}
//	}
//}
