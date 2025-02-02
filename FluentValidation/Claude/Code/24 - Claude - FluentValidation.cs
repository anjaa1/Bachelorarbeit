//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Internal;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class MessageFormatterTests {
//		private MessageFormatter _formatter;

//		[TestInitialize]
//		public void Setup() {
//			_formatter = new MessageFormatter();
//		}

//		[TestMethod]
//		public void BuildMessage_WithNoPlaceholders_ReturnsOriginalString() {
//			// Arrange
//			string template = "This is a simple message";

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(template, result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithUnmatchedPlaceholder_RetainsPlaceholderInOutput() {
//			// Arrange
//			string template = "Hello {Name}";

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(template, result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithNullTemplate_ReturnsNull() {
//			// Act
//			string result = _formatter.BuildMessage(null);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithEmptyTemplate_ReturnsEmptyString() {
//			// Act
//			string result = _formatter.BuildMessage(string.Empty);

//			// Assert
//			Assert.AreEqual(string.Empty, result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithMultiplePlaceholders_ReplacesAllMatchingPlaceholders() {
//			// Arrange
//			string template = "Hello {FirstName} {LastName}";
//			_formatter.GetType().GetField("_placeholderValues", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
//					?.SetValue(_formatter, new Dictionary<string, object>
//					{
//										{ "FirstName", "John" },
//										{ "LastName", "Doe" }
//					});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Hello John Doe", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithFormattedPlaceholder_AppliesFormatting() {
//			// Arrange
//			string template = "Amount: {Price:C2}";
//			_formatter.GetType().GetField("_placeholderValues", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
//					?.SetValue(_formatter, new Dictionary<string, object>
//					{
//										{ "Price", 42.5 }
//					});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Amount: $42.50", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithNullPlaceholderValue_ReturnsEmptyReplacement() {
//			// Arrange
//			string template = "Name: {Name}";
//			_formatter.GetType().GetField("_placeholderValues", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
//					?.SetValue(_formatter, new Dictionary<string, object>
//					{
//										{ "Name", null }
//					});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Name: ", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithInvalidFormatSpecifier_ThrowsFormatException() {
//			// Arrange
//			string template = "Number: {Value:Z}"; // 'Z' is not a valid format specifier
//			_formatter.GetType().GetField("_placeholderValues", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
//					?.SetValue(_formatter, new Dictionary<string, object>
//					{
//										{ "Value", 42 }
//					});

//			// Act & Assert
//			Assert.ThrowsException<FormatException>(() => _formatter.BuildMessage(template));
//		}
//	}
//}
