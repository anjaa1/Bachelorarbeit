//using FluentValidation.Internal;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class MessageFormatterTests {
//		[TestMethod]
//		public void BuildMessage_TypicalUsage_ReturnsMessageWithPlaceholdersReplaced() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = "The value '{PropertyName}' is invalid.";
//			var propertyName = "SomeProperty";
//			var value = "someValue";

//			formatter.AddPlaceholderValue(propertyName, value);

//			// Act
//			var result = formatter.BuildMessage(messageTemplate);

//			// Assert
//			Assert.AreEqual($"The value '{value}' is invalid.", result);
//		}

//		[TestMethod]
//		public void BuildMessage_InvalidPlaceholder_ReturnsMessageWithPlaceholder() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = "The value '{InvalidPlaceholder}' is invalid.";
//			var invalidPlaceholder = "InvalidPlaceholder";

//			// Act
//			var result = formatter.BuildMessage(messageTemplate);

//			// Assert
//			Assert.AreEqual($"The value '{invalidPlaceholder}' is invalid.", result);
//		}

//		[TestMethod]
//		public void BuildMessage_NoPlaceholder_ReturnsMessageAsIs() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = "The value is invalid.";
//			var propertyName = "SomeProperty";
//			var value = "someValue";

//			formatter.AddPlaceholderValue(propertyName, value);

//			// Act
//			var result = formatter.BuildMessage(messageTemplate);

//			// Assert
//			Assert.AreEqual(messageTemplate, result);
//		}

//		[TestMethod]
//		public void BuildMessage_FormatSpecifier_ReturnsMessageWithFormatSpecifierApplied() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = "The value '{PropertyName}' is invalid and has a length of {PropertyName:10}.";
//			var propertyName = "SomeProperty";
//			var value = "someValue";

//			formatter.AddPlaceholderValue(propertyName, value);

//			// Act
//			var result = formatter.BuildMessage(messageTemplate);

//			// Assert
//			Assert.AreEqual($"The value '{value}' is invalid and has a length of {value.PadRight(10)}.", result);
//		}

//		[TestMethod]
//		public void BuildMessage_NullMessageTemplate_ThrowsArgumentNullException() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = null;

//			// Act and Assert
//			Assert.ThrowsException<ArgumentNullException>(() => formatter.BuildMessage(messageTemplate));
//		}

//		[TestMethod]
//		public void BuildMessage_NullPlaceholderValue_ThrowsArgumentNullException() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = "The value '{PropertyName}' is invalid.";
//			var propertyName = null;

//			// Act and Assert
//			Assert.ThrowsException<ArgumentNullException>(() => formatter.AddPlaceholderValue(propertyName, "someValue"));
//		}

//		[TestMethod]
//		public void BuildMessage_NullMessageTemplate_ThrowsArgumentNullException() {
//			// Arrange
//			var formatter = new MessageFormatter();
//			var messageTemplate = null;

//			// Act and Assert
//			Assert.ThrowsException<ArgumentNullException>(() => formatter.BuildMessage(messageTemplate));
//		}

//		private void AddPlaceholderValue(MessageFormatter formatter, string key, string value) {
//			if (formatter == null) {
//				throw new ArgumentNullException(nameof(formatter));
//			}

//			if (string.IsNullOrEmpty(key)) {
//				throw new ArgumentNullException(nameof(key));
//			}

//			if (string.IsNullOrEmpty(value)) {
//				throw new ArgumentNullException(nameof(value));
//			}

//			formatter.AddPlaceholderValue(key, value);
//		}
//	}
//}
