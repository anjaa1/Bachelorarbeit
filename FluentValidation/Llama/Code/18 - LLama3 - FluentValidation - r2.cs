//using FluentValidation.TestHelper;
//using FluentValidation.Results;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;
//using FluentValidation; // Added using directive

//namespace TestProject {
//	[TestClass]
//	public class WhenAllTests {
//		[TestMethod]
//		public void WhenAll_TypicalUsage_ValidationPasses() {
//			// Arrange
//			var validator = new TestValidator();
//			var model = new TestModel();
//			var result = validator.TestValidate(model);

//			// Act
//			var continuation = result.WhenAll(f => f.ErrorMessage.Contains("valid"));

//			// Assert
//			Assert.IsTrue(continuation.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_EdgeCase_NoUnmatchedFailures_ValidationPasses() {
//			// Arrange
//			var validator = new TestValidator();
//			var model = new TestModel();
//			var result = validator.TestValidate(model);

//			// Act
//			var continuation = result.WhenAll(f => f.ErrorMessage.Contains("valid"), "No unmatched failures");

//			// Assert
//			Assert.IsTrue(continuation.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_EdgeCase_UnmatchedFailure_ThrowsValidationException() {
//			// Arrange
//			var validator = new TestValidator();
//			var model = new TestModel();
//			var result = validator.TestValidate(model);

//			// Act
//			var continuation = result.WhenAll(f => f.ErrorMessage.Contains("invalid"));

//			// Assert
//			Assert.ThrowsException<ValidationTestException>(() => continuation);
//		}

//		[TestMethod]
//		public void WhenAll_TypicalUsage_NoUnmatchedFailures_ValidationPasses() {
//			// Arrange
//			var validator = new TestValidator();
//			var model = new TestModel();
//			var result = validator.TestValidate(model);

//			// Act
//			var continuation = result.WhenAll(f => f.ErrorMessage.Contains("valid"));

//			// Assert
//			Assert.IsTrue(continuation.UnmatchedFailures.Any());
//		}

//		[TestMethod]
//		public void WhenAll_EdgeCase_NoUnmatchedFailures_NoExceptionThrown() {
//			// Arrange
//			var validator = new TestValidator();
//			var model = new TestModel();
//			var result = validator.TestValidate(model);

//			// Act
//			var continuation = result.WhenAll(f => f.ErrorMessage.Contains("valid"), "No unmatched failures");

//			// Assert
//			Assert.IsTrue(continuation.UnmatchedFailures.Any());
//		}
//	}

//	public class TestValidator : AbstractValidator<TestModel> {
//		public TestValidator() {
//			RuleFor(x => x.Name).NotEmpty();
//		}
//	}

//	public class TestModel {
//		public string Name { get; set; }
//	}
//}
