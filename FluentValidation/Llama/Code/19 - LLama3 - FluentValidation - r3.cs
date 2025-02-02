//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidation.Tests.TestHelper {
//	[TestClass]
//	public class OnlyTests {
//		[TestMethod]
//		public void Only_WithNoFailures_ReturnsSameValidationResult() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel();
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);

//			// Act
//			var result = failures.Only();

//			// Assert
//			Assert.AreEqual(failures, result);
//		}

//		[TestMethod]
//		public void Only_WithFailures_ReturnsSameValidationResult() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel { MyProperty = "Invalid" };
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);

//			// Act
//			var result = failures.Only();

//			// Assert
//			Assert.AreEqual(failures, result);
//		}

//		[TestMethod]
//		public void Only_WithUnmatchedFailures_ThrowsException() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel();
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);
//			var unmatchedFailure = new ValidationFailure { ErrorMessage = "Unmatched Failure" };
//			failures.AddUnmatchedFailure(unmatchedFailure);

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => failures.Only());
//		}

//		[TestMethod]
//		public void Only_WithUnmatchedFailuresFromParent_ThrowsException() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel();
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);
//			var parentFailures = new TestValidationContinuation { Parent = new TestValidationContinuation { UnmatchedFailures = new List<ValidationFailure> { new ValidationFailure { ErrorMessage = "Unmatched Failure" } } } };
//			var continuation = new TestValidationContinuation { Parent = parentFailures };
//			failures = continuation;

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => failures.Only());
//		}

//		[TestMethod]
//		public void Only_WithNoFailuresAndNoParent_ThrowsException() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel();
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => failures.Only());
//		}

//		[TestMethod]
//		public void Only_WithNoFailuresAndParentWithFailures_ThrowsException() {
//			// Arrange
//			var validator = new MyValidator();
//			var model = new MyModel();
//			var validationContext = new ValidationContext<MyModel>(model);
//			var failures = validator.Validate(validationContext);
//			var parentFailures = new TestValidationContinuation { UnmatchedFailures = new List<ValidationFailure> { new ValidationFailure { ErrorMessage = "Unmatched Failure" } } };
//			var continuation = new TestValidationContinuation { Parent = parentFailures };
//			failures = continuation;

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => failures.Only());
//		}

//		private class MyValidator : AbstractValidator<MyModel> {
//			public MyValidator() {
//				RuleFor(x => x.MyProperty).NotEmpty();
//			}
//		}

//		private class MyModel {
//			public string MyProperty { get; set; }
//		}
//	}
//}
