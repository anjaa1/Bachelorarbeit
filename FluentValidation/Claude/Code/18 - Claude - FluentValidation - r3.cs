//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Results;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.TestHelper {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		[TestMethod]
//		public void WhenAll_AllFailuresMatchPredicate_ReturnsSuccessfully() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act
//			var result = continuation.WhenAll(f => true);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.IsFalse(result.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_NoFailuresMatchPredicate_ThrowsValidationTestException() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => false));

//			Assert.IsTrue(exception.Message.Contains("Found an unexpected validation error"));
//		}

//		[TestMethod]
//		public void WhenAll_PartialFailuresMatch_ThrowsValidationTestException() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => f.PropertyName == "Property1"));

//			Assert.IsTrue(exception.Message.Contains("Found an unexpected validation error"));
//		}

//		[TestMethod]
//		public void WhenAll_WithCustomExceptionMessage_ThrowsWithCustomMessage() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1")
//						};
//			var continuation = new TestValidationContinuation(failures);
//			var customMessage = "Custom error message";

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => false, customMessage));

//			Assert.IsTrue(exception.Message.Contains(customMessage));
//		}

//		[TestMethod]
//		public void WhenAll_EmptyFailureList_ReturnsSuccessfully() {
//			// Arrange
//			var continuation = new TestValidationContinuation(new List<ValidationFailure>());

//			// Act
//			var result = continuation.WhenAll(f => true);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.IsFalse(result.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_NullPredicate_ThrowsArgumentNullException() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act & Assert
//			Assert.ThrowsException<ArgumentNullException>(() =>
//					continuation.WhenAll(null));
//		}

//		[TestMethod]
//		public void WhenAll_MultipleFailuresAllMatch_ReturnsSuccessfully() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2"),
//								new ValidationFailure("Property3", "Error3")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act
//			var result = continuation.WhenAll(f => true);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.IsFalse(result.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_ComplexPredicate_WorksAsExpected() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = new TestValidationContinuation(failures);

//			// Act
//			var result = continuation.WhenAll(
//					f => f.PropertyName.StartsWith("Property") &&
//							 f.ErrorMessage.StartsWith("Error"));

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.IsFalse(result.UnmatchedFailures.Any());
//		}
//	}
//}
