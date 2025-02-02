//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Results;
//using FluentValidation.TestHelper;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//[TestClass]
//public class ValidationTestExtensionTests {
//	private class MockTestValidationContinuation : ITestValidationContinuation {
//		private readonly IEnumerable<ValidationFailure> _failures;

//		public MockTestValidationContinuation(IEnumerable<ValidationFailure> failures) {
//			_failures = failures;
//		}

//		public IEnumerable<ValidationFailure> UnmatchedFailures => _failures;

//		public IEnumerator<ValidationFailure> GetEnumerator() {
//			return _failures.GetEnumerator();
//		}

//		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
//			return GetEnumerator();
//		}
//	}

//	[TestMethod]
//	public void WhenAll_ShouldPass_WhenAllFailuresMatchPredicate() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Error 1"),
//						new ValidationFailure("Property2", "Error 2")
//				};
//		var continuation = new MockTestValidationContinuation(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		var result = ValidationTestExtension.WhenAll(continuation, predicate);

//		// Assert
//		Assert.IsNotNull(result);
//	}

//	[TestMethod]
//	[ExpectedException(typeof(ValidationTestException))]
//	public void WhenAll_ShouldThrowException_WhenSomeFailuresDoNotMatchPredicate() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Error 1"),
//						new ValidationFailure("Property2", "Other Error")
//				};
//		var continuation = new MockTestValidationContinuation(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		ValidationTestExtension.WhenAll(continuation, predicate);

//		// Assert is handled by ExpectedException
//	}

//	[TestMethod]
//	[ExpectedException(typeof(ValidationTestException))]
//	public void WhenAll_ShouldThrowException_WhenNoFailuresMatchPredicate() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Other Error"),
//						new ValidationFailure("Property2", "Another Error")
//				};
//		var continuation = new MockTestValidationContinuation(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		ValidationTestExtension.WhenAll(continuation, predicate);

//		// Assert is handled by ExpectedException
//	}

//	[TestMethod]
//	public void WhenAll_ShouldPass_WhenNoFailuresPresent() {
//		// Arrange
//		var failures = new List<ValidationFailure>();
//		var continuation = new MockTestValidationContinuation(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		var result = ValidationTestExtension.WhenAll(continuation, predicate);

//		// Assert
//		Assert.IsNotNull(result);
//	}

//	[TestMethod]
//	public void WhenAll_ShouldThrowCustomExceptionMessage_WhenExceptionMessageProvided() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Other Error")
//				};
//		var continuation = new MockTestValidationContinuation(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");
//		string customMessage = "Custom exception message";

//		try {
//			// Act
//			ValidationTestExtension.WhenAll(continuation, predicate, customMessage);
//		}
//		catch (ValidationTestException ex) {
//			// Assert
//			Assert.IsTrue(ex.Message.Contains(customMessage));
//		}
//	}
//}
