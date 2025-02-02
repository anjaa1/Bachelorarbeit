//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		// Custom implementation of ITestValidationWith for testing
//		private class TestValidationImplementation : ITestValidationWith {
//			private readonly IEnumerable<ValidationFailure> _unmatchedFailures;
//			private readonly TestValidationImplementation _parent;

//			public TestValidationImplementation(IEnumerable<ValidationFailure> unmatchedFailures, TestValidationImplementation parent = null) {
//				_unmatchedFailures = unmatchedFailures;
//				_parent = parent;
//			}

//			public IEnumerable<ValidationFailure> UnmatchedFailures => _unmatchedFailures;
//			public TestValidationImplementation Parent => _parent;

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
//		public void Only_WithUnmatchedFailures_ThrowsValidationTestException() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("PropertyName", "Error message 1"),
//								new ValidationFailure("PropertyName", "Error message 2")
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
//				StringAssert.Contains(ex.Message, "Expected to have errors only matching specified conditions");
//				StringAssert.Contains(ex.Message, "[0]: Error message 1");
//			}
//		}

//		[TestMethod]
//		public void Only_WithParentContainingUnmatchedFailures_IncludesParentFailures() {
//			// Arrange
//			var parentFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("ParentProperty", "Parent error")
//						};
//			var childFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("ChildProperty", "Child error")
//						};

//			var parent = new TestValidationImplementation(parentFailures);
//			var child = new TestValidationImplementation(childFailures, parent);

//			try {
//				// Act
//				child.Only();
//				Assert.Fail("Expected ValidationTestException was not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				// Assert
//				StringAssert.Contains(ex.Message, "Parent error");
//				StringAssert.Contains(ex.Message, "Child error");
//			}
//		}

//		[TestMethod]
//		public void Only_WithMultipleNestedParents_IncludesAllParentFailures() {
//			// Arrange
//			var grandParentFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("GrandParentProperty", "GrandParent error")
//						};
//			var parentFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("ParentProperty", "Parent error")
//						};
//			var childFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("ChildProperty", "Child error")
//						};

//			var grandParent = new TestValidationImplementation(grandParentFailures);
//			var parent = new TestValidationImplementation(parentFailures, grandParent);
//			var child = new TestValidationImplementation(childFailures, parent);

//			try {
//				// Act
//				child.Only();
//				Assert.Fail("Expected ValidationTestException was not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				// Assert
//				StringAssert.Contains(ex.Message, "GrandParent error");
//				StringAssert.Contains(ex.Message, "Parent error");
//				StringAssert.Contains(ex.Message, "Child error");
//			}
//		}

//	}
//}
