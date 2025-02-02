//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		private class TestValidationClass : TestValidationContinuation, ITestValidationWith {
//			private readonly IEnumerable<ValidationFailure> _unmatchedFailures;
//			private readonly TestValidationClass _parent;

//			public TestValidationClass(IEnumerable<ValidationFailure> unmatchedFailures, TestValidationClass parent = null)
//					: base(null)  // Base class requires a validator, but we can pass null for testing
//			{
//				_unmatchedFailures = unmatchedFailures;
//				_parent = parent;
//			}

//			public override IEnumerable<ValidationFailure> UnmatchedFailures => _unmatchedFailures;
//			public override TestValidationContinuation Parent => _parent;
//		}

//		[TestMethod]
//		public void Only_WithNoUnmatchedFailures_ReturnsOriginalObject() {
//			// Arrange
//			var validation = new TestValidationClass(Enumerable.Empty<ValidationFailure>());

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
//			var validation = new TestValidationClass(unmatchedFailures);

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
//			var validation = new TestValidationClass(unmatchedFailures);

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

//			var parent = new TestValidationClass(parentFailures);
//			var child = new TestValidationClass(childFailures, parent);

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

//			var grandParent = new TestValidationClass(grandParentFailures);
//			var parent = new TestValidationClass(parentFailures, grandParent);
//			var child = new TestValidationClass(childFailures, parent);

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
