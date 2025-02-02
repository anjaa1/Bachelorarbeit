//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.TestHelper;
//using System;
//using System.Linq.Expressions;
//using System.Collections.Generic;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		// Test models
//		private class TestModel {
//			public ChildModel Child { get; set; }
//			public string Name { get; set; }
//			public List<ChildModel> Children { get; set; } = new List<ChildModel>();
//		}

//		private class ChildModel {
//			public string Property { get; set; }
//		}

//		// Test validators
//		private class ChildValidator : AbstractValidator<ChildModel> {
//			public ChildValidator() {
//				RuleFor(x => x.Property).NotEmpty();
//			}
//		}

//		private class TestModelValidator : AbstractValidator<TestModel> {
//			public TestModelValidator() {
//				RuleFor(x => x.Child).SetValidator(new ChildValidator());
//				RuleFor(x => x.Name).NotEmpty();
//			}
//		}

//		private class ModelWithChildValidator : AbstractValidator<TestModel> {
//			public ModelWithChildValidator() {
//				RuleForEach(x => x.Children).SetValidator(new ChildValidator());
//			}
//		}

//		private class DifferentChildValidator : AbstractValidator<ChildModel> {
//			public DifferentChildValidator() {
//				RuleFor(x => x.Property).NotNull();
//			}
//		}

//		private TestModelValidator validator;

//		[TestInitialize]
//		public void Setup() {
//			validator = new TestModelValidator();
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_WhenChildValidatorExists_ShouldNotThrow() {
//			// Arrange
//			Expression<Func<TestModel, ChildModel>> expression = x => x.Child;

//			// Act & Assert
//			validator.ShouldHaveChildValidator(expression, typeof(ChildValidator));
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_WhenChildValidatorIsAssignableFrom_ShouldNotThrow() {
//			// Arrange
//			Expression<Func<TestModel, ChildModel>> expression = x => x.Child;

//			// Act & Assert
//			validator.ShouldHaveChildValidator(expression, typeof(IValidator<ChildModel>));
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void ShouldHaveChildValidator_WhenChildValidatorDoesNotExist_ShouldThrow() {
//			// Arrange
//			Expression<Func<TestModel, string>> expression = x => x.Name;

//			// Act & Assert
//			validator.ShouldHaveChildValidator(expression, typeof(ChildValidator));
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ValidationTestException))]
//		public void ShouldHaveChildValidator_WhenWrongChildValidatorType_ShouldThrow() {
//			// Arrange
//			Expression<Func<TestModel, ChildModel>> expression = x => x.Child;

//			// Act & Assert
//			validator.ShouldHaveChildValidator(expression, typeof(DifferentChildValidator));
//		}

//		[TestMethod]
//		[ExpectedException(typeof(NotSupportedException))]
//		public void ShouldHaveChildValidator_WhenComplexExpression_ShouldThrow() {
//			// Arrange
//			Expression<Func<TestModel, string>> expression = x => x.Child.Property + "suffix";

//			// Act & Assert
//			validator.ShouldHaveChildValidator(expression, typeof(ChildValidator));
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_WhenCollectionValidation_ShouldNotThrow() {
//			// Arrange
//			var modelValidator = new ModelWithChildValidator();
//			Expression<Func<TestModel, IEnumerable<ChildModel>>> expression = x => x.Children;

//			// Act & Assert
//			modelValidator.ShouldHaveChildValidator(expression, typeof(ChildValidator));
//		}
//	}
//}
