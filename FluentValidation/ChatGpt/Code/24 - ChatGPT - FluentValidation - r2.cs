//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Internal;
//using System;
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
//		public void BuildMessage_AppliesFormatWhenSpecified() {
//			// Arrange
//			var placeholderValues = new Dictionary<string, object> { { "Date", new DateTime(2025, 1, 1) } };
//			SetPlaceholderValues(placeholderValues);
//			string template = "Today is {Date:yyyy-MM-dd}.";
//			string expected = "Today is 2025-01-01.";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_ReplacesSinglePlaceholderWithCorrectValue() {
//			// Arrange
//			var placeholderValues = new Dictionary<string, object> { { "Name", "John" } };
//			SetPlaceholderValues(placeholderValues);
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
//			var placeholderValues = new Dictionary<string, object> { { "FirstName", "John" }, { "LastName", "Doe" } };
//			SetPlaceholderValues(placeholderValues);
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
//			string result = template == null ? "" : _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		[TestMethod]
//		public void BuildMessage_HandlesPlaceholdersWithNullValues() {
//			// Arrange
//			var placeholderValues = new Dictionary<string, object> { { "Name", null } };
//			SetPlaceholderValues(placeholderValues);
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
//			var placeholderValues = new Dictionary<string, object> { { "Name", "John" } };
//			SetPlaceholderValues(placeholderValues);
//			string template = "Welcome!";
//			string expected = "Welcome!";

//			// Act
//			string result = _messageFormatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(expected, result);
//		}

//		private void SetPlaceholderValues(Dictionary<string, object> placeholderValues) {
//			var field = _messageFormatter.GetType().GetField("_placeholderValues", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//			if (field != null) {
//				field.SetValue(_messageFormatter, placeholderValues);
//			}
//		}
//	}
//}
