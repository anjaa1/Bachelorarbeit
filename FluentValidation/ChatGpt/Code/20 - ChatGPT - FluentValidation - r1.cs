//using System;
//using System.Linq.Expressions;
//using FluentValidation;
//using FluentValidation.TestHelper;
//using FluentValidation.Validators;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidationTests {
//	[TestClass]
//	public class ValidationTestExtensionTests {

//		private class TestModel {
//			public string ChildProperty { get; set; }
//		}

//		private class ChildValidator : AbstractValidator<string> {
//		}

//		private class TestModelValidator : AbstractValidator<TestModel> {
//			public TestModelValidator() {
//				RuleFor(x => x.ChildProperty).SetValidator(new ChildValidator());
//			}
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_ValidChildValidatorType_Passes() {
//			// Arrange
//			var validator = new TestModelValidator();

//			// Act & Assert
//			validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(ChildValidator));
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_InvalidChildValidatorType_ThrowsException() {
//			// Arrange
//			var validator = new TestModelValidator();

//			// Act & Assert
//			try {
//				validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(AbstractValidator<int>));
//				Assert.Fail("Expected ValidationTestException not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				Assert.IsTrue(ex.Message.Contains("Expected property 'ChildProperty' to have a child validator"));
//			}
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_InvalidExpression_ThrowsException() {
//			// Arrange
//			var validator = new TestModelValidator();

//			// Act & Assert
//			try {
//				validator.ShouldHaveChildValidator(x => x.ChildProperty.Length, typeof(ChildValidator));
//				Assert.Fail("Expected NotSupportedException not thrown.");
//			}
//			catch (NotSupportedException ex) {
//				Assert.IsTrue(ex.Message.Contains("ShouldHaveChildValidator can only be used for simple property expressions"));
//			}
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_NoChildValidatorForProperty_ThrowsValidationTestException() {
//			// Arrange
//			var validator = new InlineValidator<TestModel>();
//			validator.RuleFor(x => x.ChildProperty).NotNull();

//			// Act & Assert
//			try {
//				validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(ChildValidator));
//				Assert.Fail("Expected ValidationTestException not thrown.");
//			}
//			catch (ValidationTestException ex) {
//				Assert.IsTrue(ex.Message.Contains("Expected property 'ChildProperty' to have a child validator"));
//			}
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_ValidModelLevelRule_Passes() {
//			// Arrange
//			var validator = new InlineValidator<TestModel>();
//			validator.RuleFor(x => x.ChildProperty).SetValidator(new ChildValidator());

//			// Act & Assert
//			validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(ChildValidator));
//		}
//	}
//}
