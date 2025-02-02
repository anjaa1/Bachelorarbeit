//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using System.Collections.Generic;
//using System.Linq;
//using Moq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		private Mock<ITestValidationWith> _mockValidation;
//		private Mock<TestValidationContinuation> _mockContinuation;

//		[TestInitialize]
//		public void Setup() {
//			_mockValidation = new Mock<ITestValidationWith>();
//			_mockContinuation = new Mock<TestValidationContinuation>();
//		}

//		[TestMethod]
//		public void Only_WithNoUnmatchedFailures_ReturnsOriginalObject() {
//			// Arrange
//			_mockValidation.Setup(x => x.UnmatchedFailures).Returns(Enumerable.Empty<ValidationFailure>());
//			var validationWith = _mockValidation.Object;

//			// Act
//			var result = validationWith.Only();

//			// Assert
//			Assert.AreEqual(validationWith, result);
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
//			_mockValidation.Setup(x => x.UnmatchedFailures).Returns(unmatchedFailures);
//			var validationWith = _mockValidation.Object;

//			// Act
//			validationWith.Only();
//		}

//		[TestMethod]
//		public void Only_WithUnmatchedFailures_ThrowsExceptionWithCorrectMessage() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure>
//			{
//								new ValidationFailure("PropertyName", "Error message 1")
//						};
//			_mockValidation.Setup(x => x.UnmatchedFailures).Returns(unmatchedFailures);
//			var validationWith = _mockValidation.Object;

//			try {
//				// Act
//				validationWith.Only();
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

//			var parentContinuation = new Mock<TestValidationContinuation>();
//			parentContinuation.Setup(x => x.UnmatchedFailures).Returns(parentFailures);

//			_mockContinuation.Setup(x => x.Parent).Returns(parentContinuation.Object);
//			_mockContinuation.Setup(x => x.UnmatchedFailures).Returns(childFailures);
//			_mockValidation.Setup(x => x.UnmatchedFailures).Returns(childFailures);

//			try {
//				// Act
//				_mockContinuation.Object.Only();
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

//			var grandParentContinuation = new Mock<TestValidationContinuation>();
//			grandParentContinuation.Setup(x => x.UnmatchedFailures).Returns(grandParentFailures);

//			var parentContinuation = new Mock<TestValidationContinuation>();
//			parentContinuation.Setup(x => x.UnmatchedFailures).Returns(parentFailures);
//			parentContinuation.Setup(x => x.Parent).Returns(grandParentContinuation.Object);

//			_mockContinuation.Setup(x => x.Parent).Returns(parentContinuation.Object);
//			_mockContinuation.Setup(x => x.UnmatchedFailures).Returns(childFailures);
//			_mockValidation.Setup(x => x.UnmatchedFailures).Returns(childFailures);

//			try {
//				// Act
//				_mockContinuation.Object.Only();
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
