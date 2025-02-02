//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		private class TestValidationImplementation : ITestValidationWith {
//			private readonly IEnumerable<ValidationFailure> _unmatchedFailures;
//			private readonly ITestValidationContinuation _parent;

//			public TestValidationImplementation(IEnumerable<ValidationFailure> unmatchedFailures, ITestValidationContinuation parent = null) {
//				_unmatchedFailures = unmatchedFailures;
//				_parent = parent;
//			}

//			public IEnumerable<ValidationFailure> UnmatchedFailures => _unmatchedFailures;

//			public IEnumerator<ValidationFailure> GetEnumerator() {
//				return _unmatchedFailures.GetEnumerator();
//			}

//			IEnumerator IEnumerable.GetEnumerator() {
//				return GetEnumerator();
//			}
//		}

//		[TestMethod]
//		public void Only_WithNoUnmatchedFailures_ReturnsOriginalObject() {
//			// Arrange
//			var validation = new TestValidationImplementation(Enumerable.Empty<ValidationFailure>());

//			// Act
//			var result = validation.Only();

//			// Assert
//			Assert.AreEqual(validation, result);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void Only_WithSingleUnmatchedFailure_ThrowsValidationTestException() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("PropertyName", "Error message 1")
//						};
//			var validation = new TestValidationImplementation(unmatchedFailures);

//			// Act
//			validation.Only();
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void Only_WithMultipleUnmatchedFailures_ThrowsValidationTestException() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("PropertyName1", "Error message 1"),
//								new ValidationFailure("PropertyName2", "Error message 2")
//						};
//			var validation = new TestValidationImplementation(unmatchedFailures);

//			// Act
//			validation.Only();
//		}

//		[TestMethod]
//		public void Only_WithUnmatchedFailures_ThrowsExceptionWithCorrectMessage() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("PropertyName", "Error message 1")
//						};
//			var validation = new TestValidationImplementation(unmatchedFailures);

//			try {
//				// Act
//				validation.Only();
//				Assert.Fail("Expected ValidationTestException was not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				// Assert
//				Assert.IsTrue(ex.Message.Contains("Expected to have errors only matching specified conditions"));
//				Assert.IsTrue(ex.Message.Contains("[0]: Error message 1"));
//			}
//		}

//		[TestMethod]
//		public void Only_WithParentContainingUnmatchedFailures_ThrowsValidationTestException() {
//			// Arrange
//			var parentFailure = new ValidationFailure("ParentProperty", "Parent error");
//			var parent = new TestValidationImplementation(new[] { parentFailure });
//			var child = new TestValidationImplementation(Enumerable.Empty<ValidationFailure>(), parent);

//			// Act & Assert
//			try {
//				child.Only();
//				Assert.Fail("Expected ValidationTestException was not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				Assert.IsTrue(ex.Message.Contains("Parent error"));
//			}
//		}

//		[TestMethod]
//		public void Only_WithNullParent_OnlyValidatesCurrentFailures() {
//			// Arrange
//			var validation = new TestValidationImplementation(Enumerable.Empty<ValidationFailure>(), null);

//			// Act
//			var result = validation.Only();

//			// Assert
//			Assert.AreEqual(validation, result);
//		}

//		[TestMethod]
//		public void Only_WithEmptyFailuresButParentFailures_ThrowsValidationTestException() {
//			// Arrange
//			var parentFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("ParentProperty", "Parent error")
//						};
//			var parent = new TestValidationImplementation(parentFailures);
//			var child = new TestValidationImplementation(Enumerable.Empty<ValidationFailure>(), parent);

//			// Act & Assert
//			try {
//				child.Only();
//				Assert.Fail("Expected ValidationTestException was not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				Assert.IsTrue(ex.Message.Contains("Parent error"));
//			}
//		}
//	}
//}
