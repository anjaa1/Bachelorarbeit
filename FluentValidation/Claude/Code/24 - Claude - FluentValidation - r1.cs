//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Internal;
//using System.Collections.Generic;
//using System.Reflection;
//using System;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class MessageFormatterTests {
//		private MessageFormatter _formatter;
//		private FieldInfo _placeholderValuesField;

//		[TestInitialize]
//		public void Setup() {
//			_formatter = new MessageFormatter();
//			_placeholderValuesField = typeof(MessageFormatter).GetField("_placeholderValues",
//					BindingFlags.NonPublic | BindingFlags.Instance);
//		}

//		private void SetPlaceholderValues(Dictionary<string, object> values) {
//			var dictionary = new Dictionary<string, object>(values);
//			_placeholderValuesField.SetValue(_formatter, dictionary);
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
//			SetPlaceholderValues(new Dictionary<string, object>());

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual(template, result);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentNullException))]
//		public void BuildMessage_WithNullTemplate_ThrowsArgumentNullException() {
//			_formatter.BuildMessage(null);
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
//			SetPlaceholderValues(new Dictionary<string, object>
//			{
//								{ "FirstName", "John" },
//								{ "LastName", "Doe" }
//						});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Hello John Doe", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithNumericFormatting_AppliesFormatCorrectly() {
//			// Arrange
//			string template = "Number: {Value:N2}";
//			SetPlaceholderValues(new Dictionary<string, object>
//			{
//								{ "Value", 1234.5678 }
//						});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			// Using ToString to handle culture-specific formatting
//			Assert.AreEqual($"Number: {1234.5678.ToString("N2")}", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithNullPlaceholderValue_ReturnsEmptyString() {
//			// Arrange
//			string template = "Name: {Name}";
//			SetPlaceholderValues(new Dictionary<string, object>
//			{
//								{ "Name", null }
//						});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Name: ", result);
//		}

//		[TestMethod]
//		public void BuildMessage_WithMixedPlaceholders_HandlesCorrectly() {
//			// Arrange
//			string template = "{Exists} and {DoesNotExist} and {AlsoExists}";
//			SetPlaceholderValues(new Dictionary<string, object>
//			{
//								{ "Exists", "Hello" },
//								{ "AlsoExists", "World" }
//						});

//			// Act
//			string result = _formatter.BuildMessage(template);

//			// Assert
//			Assert.AreEqual("Hello and {DoesNotExist} and World", result);
//		}
//	}
//}
