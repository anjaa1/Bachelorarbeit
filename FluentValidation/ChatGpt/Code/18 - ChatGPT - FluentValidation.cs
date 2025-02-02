//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Results;
//using FluentValidation.TestHelper;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//[TestClass]
//public class ValidationTestExtensionTests {
//	private class TestValidationContinuationMock : ITestValidationContinuation {
//		private readonly List<ValidationFailure> _failures;

//		public TestValidationContinuationMock(IEnumerable<ValidationFailure> failures) {
//			_failures = failures.ToList();
//		}

//		public IEnumerable<ValidationFailure> UnmatchedFailures => _failures;

//		public IEnumerator<ValidationFailure> GetEnumerator() {
//			return _failures.GetEnumerator();
//		}

//		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
//			return _failures.GetEnumerator();
//		}
//	}

//	[TestMethod]
//	public void WhenAll_ShouldPass_WhenAllFailuresMatchPredicate() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Error 1"),
//						new ValidationFailure("Property2", "Error 2")
//				};
//		var mockContinuation = new TestValidationContinuationMock(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		var result = ValidationTestExtension.WhenAll(mockContinuation, predicate);

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
//		var mockContinuation = new TestValidationContinuationMock(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		ValidationTestExtension.WhenAll(mockContinuation, predicate);

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
//		var mockContinuation = new TestValidationContinuationMock(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		ValidationTestExtension.WhenAll(mockContinuation, predicate);

//		// Assert is handled by ExpectedException
//	}

//	[TestMethod]
//	public void WhenAll_ShouldPass_WhenNoFailuresPresent() {
//		// Arrange
//		var failures = new List<ValidationFailure>();
//		var mockContinuation = new TestValidationContinuationMock(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");

//		// Act
//		var result = ValidationTestExtension.WhenAll(mockContinuation, predicate);

//		// Assert
//		Assert.IsNotNull(result);
//	}

//	[TestMethod]
//	public void WhenAll_ShouldThrowCustomExceptionMessage_WhenExceptionMessageProvided() {
//		// Arrange
//		var failures = new List<ValidationFailure> {
//						new ValidationFailure("Property1", "Other Error")
//				};
//		var mockContinuation = new TestValidationContinuationMock(failures);
//		Func<ValidationFailure, bool> predicate = failure => failure.ErrorMessage.Contains("Error");
//		string customMessage = "Custom exception message";

//		try {
//			// Act
//			ValidationTestExtension.WhenAll(mockContinuation, predicate, customMessage);
//		}
//		catch (ValidationTestException ex) {
//			// Assert
//			Assert.IsTrue(ex.Message.Contains(customMessage));
//		}
//	}
//}
