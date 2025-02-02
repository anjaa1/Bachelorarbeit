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
//		private Mock<TestValidationContinuation> _mockParentValidationContinuation;

//		[TestInitialize]
//		public void SetUp() {
//			_mockValidationWith = new Mock<ITestValidationWith>();
//			_mockParentValidationContinuation = new Mock<TestValidationContinuation>();
//		}

//		[TestMethod]
//		public void Only_NoUnmatchedFailures_DoesNotThrowException() {
//			// Arrange
//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(new List<ValidationFailure>());

//			// Act
//			var result = _mockValidationWith.Object.Only();

//			// Assert
//			Assert.AreEqual(_mockValidationWith.Object, result);
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

//			var testValidationContinuation = new TestValidationContinuation { Parent = _mockParentValidationContinuation.Object };
//			_mockValidationWith.Setup(v => v.UnmatchedFailures).Returns(unmatchedFailures);
//			_mockValidationWith.Setup(v => ((TestValidationContinuation)v)).Returns(testValidationContinuation);

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

//	// Mock implementation of TestValidationContinuation for testing purposes
//	public class TestValidationContinuation : ITestValidationContinuation {
//		public IEnumerable<ValidationFailure> UnmatchedFailures { get; set; } = new List<ValidationFailure>();
//		public TestValidationContinuation Parent { get; set; }

//		public IEnumerator<ValidationFailure> GetEnumerator() => UnmatchedFailures.GetEnumerator();
//		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
//	}
//}
