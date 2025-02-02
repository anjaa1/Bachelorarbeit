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
//		public void IsValid_WithNullValue_ReturnsTrue() {
//			// Arrange
//			string nullCard = null;

//			// Act
//			bool result = validator.IsValid(context, nullCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithEmptyString_ReturnsTrue() {
//			// Arrange
//			string emptyCard = string.Empty;

//			// Act
//			bool result = validator.IsValid(context, emptyCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithAllZeros_ReturnsTrue() {
//			// Arrange
//			string allZeros = "0000000000000000";

//			// Act
//			bool result = validator.IsValid(context, allZeros);

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
//		public void IsValid_WithValidFormattedCard_ReturnsTrue() {
//			// Arrange - Valid card with dashes and spaces
//			string formattedCard = "4532-0151 1283-0366";

//			// Act
//			bool result = validator.IsValid(context, formattedCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithInvalidChecksum_ReturnsFalse() {
//			// Arrange - Invalid checksum
//			string invalidCard = "4532015112830367";

//			// Act
//			bool result = validator.IsValid(context, invalidCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		// Helper class for testing
//		private class TestModel {
//			public string CreditCardNumber { get; set; }
//		}
//	}
//}
