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
//			// Arrange - Valid Visa: 4532015112830366
//			string validCard = "4532015112830366";

//			// Act
//			bool result = validator.IsValid(context, validCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithValidMasterCard_ReturnsTrue() {
//			// Arrange - Valid MasterCard: 5425233430109903
//			string validCard = "5425233430109903";

//			// Act
//			bool result = validator.IsValid(context, validCard);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void IsValid_WithFormattedCard_ReturnsTrue() {
//			// Arrange - Card with spaces and dashes
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
//		public void IsValid_WithInvalidCharacters_ReturnsFalse() {
//			// Arrange
//			string invalidCard = "4532015112830366a";

//			// Act
//			bool result = validator.IsValid(context, invalidCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithInvalidChecksum_ReturnsFalse() {
//			// Arrange - Modified last digit to make checksum invalid
//			string invalidCard = "4532015112830367";

//			// Act
//			bool result = validator.IsValid(context, invalidCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithEmptyString_ReturnsFalse() {
//			// Arrange
//			string emptyCard = "";

//			// Act
//			bool result = validator.IsValid(context, emptyCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void IsValid_WithAllZeros_ReturnsFalse() {
//			// Arrange
//			string zeroCard = "0000000000000000";

//			// Act
//			bool result = validator.IsValid(context, zeroCard);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		// Helper class for testing
//		private class TestModel {
//			public string CreditCardNumber { get; set; }
//		}
//	}
//}
