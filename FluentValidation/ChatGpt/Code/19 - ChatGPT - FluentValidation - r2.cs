//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using System.Collections.Generic;
//using System.Linq;
//using Moq;

//namespace FluentValidation.TestHelper.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {

//		private Mock<ITestValidationWith> _mockValidationWith;
//		private Mock<ITestValidationContinuation> _mockParentValidationContinuation;

//		[TestInitialize]
//		public void SetUp() {
//			_mockValidationWith = new Mock<ITestValidationWith>();
//			_mockParentValidationContinuation = new Mock<ITestValidationContinuation>();
//		}

//		[TestMethod]
//		public void Only_NoUnmatchedFailures_DoesNotThrowException() {
//			// Arrange
//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(new List<ValidationFailure>());

//			// Act & Assert
//			_mockValidationWith.Object.Only();
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void Only_WithUnmatchedFailures_ThrowsValidationTestException() {
//			// Arrange
//			var unmatchedFailures = new List<ValidationFailure> {
//								new ValidationFailure("Property1", "Error message 1"),
//								new ValidationFailure("Property2", "Error message 2")
//						};

//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(unmatchedFailures);

//			// Act
//			_mockValidationWith.Object.Only();
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void Only_WithParentUnmatchedFailures_ThrowsValidationTestException() {
//			// Arrange
//			var parentUnmatchedFailures = new List<ValidationFailure> {
//								new ValidationFailure("ParentProperty", "Parent error message")
//						};

//			var unmatchedFailures = new List<ValidationFailure> {
//								new ValidationFailure("ChildProperty", "Child error message")
//						};

//			_mockParentValidationContinuation.Setup(p => p.UnmatchedFailures).Returns(parentUnmatchedFailures);

//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(unmatchedFailures);
//			_mockValidationWith.Setup(v => ((ITestValidationContinuation)v).UnmatchedFailures)
//					.Returns(unmatchedFailures.Concat(parentUnmatchedFailures));

//			// Act
//			_mockValidationWith.Object.Only();
//		}

//		[TestMethod]
//		public void Only_WithNoFailures_ReturnsValidationWith() {
//			// Arrange
//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(new List<ValidationFailure>());

//			// Act
//			var result = _mockValidationWith.Object.Only();

//			// Assert
//			Assert.AreEqual(_mockValidationWith.Object, result);
//		}
//	}
//}
