//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Results;
//using FluentValidation.TestHelper;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		private TestValidationContinuation CreateContinuation(IEnumerable<ValidationFailure> failures) {
//			// Using the actual TestValidationContinuation class
//			return new TestValidationContinuation(failures);
//		}

//		[TestMethod]
//		public void WhenAll_AllFailuresMatchPredicate_ReturnsSuccessfully() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = CreateContinuation(failures);

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
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = CreateContinuation(failures);

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => false));

//			StringAssert.Contains(exception.Message, "Found an unexpected validation error");
//		}

//		[TestMethod]
//		public void WhenAll_PartialFailuresMatch_ThrowsValidationTestException() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = CreateContinuation(failures);

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => f.PropertyName == "Property1"));

//			StringAssert.Contains(exception.Message, "Found an unexpected validation error");
//		}

//		[TestMethod]
//		public void WhenAll_WithCustomExceptionMessage_ThrowsWithCustomMessage() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1")
//						};
//			var continuation = CreateContinuation(failures);
//			var customMessage = "Custom error message";

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => false, customMessage));

//			StringAssert.Contains(exception.Message, customMessage);
//		}

//		[TestMethod]
//		public void WhenAll_EmptyFailureList_ReturnsSuccessfully() {
//			// Arrange
//			var continuation = CreateContinuation(new List<ValidationFailure>());

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
//			var continuation = CreateContinuation(failures);

//			// Act & Assert
//			Assert.ThrowsException<ArgumentNullException>(() =>
//					continuation.WhenAll(null));
//		}

//		[TestMethod]
//		public void WhenAll_PredicateMatchingSpecificError_ReturnsSuccessfully() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "SpecificError"),
//								new ValidationFailure("Property2", "DifferentError")
//						};
//			var continuation = CreateContinuation(failures);

//			// Act
//			var result = continuation.WhenAll(f =>
//					f.PropertyName == "Property1" && f.ErrorMessage == "SpecificError" ||
//					f.PropertyName == "Property2" && f.ErrorMessage == "DifferentError");

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.IsFalse(result.UnmatchedFailures.Any());
//		}
//	}
//}
