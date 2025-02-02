//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Validators;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class CreditCardValidatorTests {
//		private CreditCardValidator<TestModel> validator;
//		private ValidationContext<TestModel> context;
//		private TestModel model;

//		[TestInitialize]
//		public void Setup() {
//			validator = new CreditCardValidator<TestModel>();
//			model = new TestModel();
//			context = new ValidationContext<TestModel>(model);
//		}

//		[TestMethod]
//		public void IsValid_WithValidVisaCard_ReturnsTrue() {
//			// Arrange - Valid Visa (passes Luhn algorithm)
//			string validCard = "4532015112830366";

//			// Act
//			bool result = validator.IsValid(context, validCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithFormattedCard_ReturnsTrue() {
//			// Arrange - Valid card with formatting
//			string formattedCard = "4532-0151 1283-0366";

//			// Act
//			bool result = validator.IsValid(context, formattedCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithNullValue_ReturnsTrue() {
//			// Arrange
//			string nullCard = null;

//			// Act
//			bool result = validator.IsValid(context, nullCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithNonNumericCharacters_ReturnsFalse() {
//			// Arrange
//			string invalidCard = "4532015112830366a";

//			// Act
//			bool result = validator.IsValid(context, invalidCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithInvalidChecksum_ReturnsFalse() {
//			// Arrange - Valid format but fails Luhn algorithm
//			string invalidCard = "4532015112830367";

//			// Act
//			bool result = validator.IsValid(context, invalidCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithEmptyString_ReturnsFalse() {
//			// Arrange
//			string emptyCard = string.Empty;

//			// Act
//			bool result = validator.IsValid(context, emptyCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithValidAmexCard_ReturnsTrue() {
//			// Arrange - Valid American Express (passes Luhn algorithm)
//			string validAmex = "378282246310005";

//			// Act
//			bool result = validator.IsValid(context, validAmex);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithAllZeros_ReturnsFalse() {
//			// Arrange - All zeros fails Luhn algorithm
//			string allZeros = "0000000000000000";

//			// Act
//			bool result = validator.IsValid(context, allZeros);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithSingleDigit_ReturnsFalse() {
//			// Arrange
//			string singleDigit = "5";

//			// Act
//			bool result = validator.IsValid(context, singleDigit);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		// Helper class for testing
//		private class TestModel {
//			public string CreditCardNumber { get; set; }
//		}
//	}
//}
