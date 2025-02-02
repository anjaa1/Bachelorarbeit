//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Results;
//using FluentValidation.TestHelper;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		public class TestValidationWrapper : ITestValidationContinuation {
//			private readonly List<ValidationFailure> _allFailures;
//			private readonly List<ValidationFailure> _matchedFailures;
//			private readonly List<ValidationFailure> _unmatchedFailures;

//			public TestValidationWrapper(IEnumerable<ValidationFailure> failures) {
//				_allFailures = failures.ToList();
//				_matchedFailures = failures.ToList();
//				_unmatchedFailures = new List<ValidationFailure>();
//			}

//			public IEnumerable<ValidationFailure> UnmatchedFailures => _unmatchedFailures;

//			public IEnumerable<ValidationFailure> MatchedFailures => _matchedFailures;

//			public void SetUnmatched(ValidationFailure failure) {
//				if (!_unmatchedFailures.Contains(failure)) {
//					_unmatchedFailures.Add(failure);
//					_matchedFailures.Remove(failure);
//				}
//			}

//			public IEnumerator<ValidationFailure> GetEnumerator() {
//				return _allFailures.GetEnumerator();
//			}

//			IEnumerator IEnumerable.GetEnumerator() {
//				return GetEnumerator();
//			}
//		}

//		[TestMethod]
//		public void WhenAll_AllFailuresMatchPredicate_ReturnsSuccessfully() {
//			// Arrange
//			var failures = new List<ValidationFailure>
//			{
//								new ValidationFailure("Property1", "Error1"),
//								new ValidationFailure("Property2", "Error2")
//						};
//			var continuation = new TestValidationWrapper(failures);

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
//			var continuation = new TestValidationWrapper(failures);

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
//			var continuation = new TestValidationWrapper(failures);

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
//			var continuation = new TestValidationWrapper(failures);
//			var customMessage = "Custom error message";

//			// Act & Assert
//			var exception = Assert.ThrowsException<ValidationTestException>(() =>
//					continuation.WhenAll(f => false, customMessage));

//			Assert.IsTrue(exception.Message.Contains(customMessage));
//		}

//		[TestMethod]
//		public void WhenAll_EmptyFailureList_ReturnsSuccessfully() {
//			// Arrange
//			var continuation = new TestValidationWrapper(new List<ValidationFailure>());

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
//			var continuation = new TestValidationWrapper(failures);

//			// Act & Assert
//			Assert.ThrowsException<ArgumentNullException>(() =>
//					continuation.WhenAll(null));
//		}
//	}
//}
