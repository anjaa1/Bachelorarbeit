//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Internal;
//using System.Collections.Generic;

//namespace FluentValidation.Tests {

//	[TestClass]
//	public class MessageFormatterTests {

//		private MessageFormatter _messageFormatter;

//		[TestInitialize]
//		public void SetUp() {
//			_messageFormatter = new MessageFormatter();
//		}

//		[TestMethod]
//		public void BuildMessage_ReplacesSinglePlaceholderWithCorrectValue() {
//			// Arrange
//			_messageFormatter.Placeholders["Name"] = "John";
//			string template = "Hello, {Name}!";
//			string expected = "Hello, John!";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_ReplacesMultiplePlaceholdersWithCorrectValues() {
//			// Arrange
//			_messageFormatter.Placeholders["FirstName"] = "John";
//			_messageFormatter.Placeholders["LastName"] = "Doe";
//			string template = "{FirstName} {LastName} is here.";
//			string expected = "John Doe is here.";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_HandlesMissingPlaceholdersGracefully() {
//			// Arrange
//			string template = "Hello, {Name}!";
//			string expected = "Hello, {Name}!"; // Placeholder not replaced

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_AppliesFormatWhenSpecified() {
//			// Arrange
//			_messageFormatter.Placeholders["Date"] = new DateTime(2025, 1, 1);
//			string template = "Today is {Date:yyyy-MM-dd}.";
//			string expected = "Today is 2025-01-01.";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_IgnoresInvalidPlaceholders() {
//			// Arrange
//			string template = "Invalid placeholder: {Invalid}";
//			string expected = "Invalid placeholder: {Invalid}";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		[DataRow(null, "", DisplayName = "Null template")]
//		[DataRow("", "", DisplayName = "Empty template")]
//		public void BuildMessage_HandlesNullOrEmptyTemplate(string template, string expected) {
//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_HandlesPlaceholdersWithNullValues() {
//			// Arrange
//			_messageFormatter.Placeholders["Name"] = null;
//			string template = "Hello, {Name}!";
//			string expected = "Hello, !";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_IgnoresUnusedPlaceholders() {
//			// Arrange
//			_messageFormatter.Placeholders["Name"] = "John";
//			string template = "Welcome!";
//			string expected = "Welcome!";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}
//	}
//}
