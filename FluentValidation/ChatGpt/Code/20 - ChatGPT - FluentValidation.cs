//using System;
//using System.Linq.Expressions;
//using FluentValidation;
//using FluentValidation.TestHelper;
//using FluentValidation.Validators;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;

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
//		[ExpectedException(typeof(ValidationTestException))]
//		public void ShouldHaveChildValidator_InvalidChildValidatorType_ThrowsException() {
//			// Arrange
//			var validator = new TestModelValidator();

//			// Act & Assert
//			validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(AbstractValidator<int>));
//		}

//		[TestMethod]
//		[ExpectedException(typeof(NotSupportedException))]
//		public void ShouldHaveChildValidator_InvalidExpression_ThrowsException() {
//			// Arrange
//			var validator = new TestModelValidator();

//			// Act & Assert
//			validator.ShouldHaveChildValidator(x => x.ChildProperty.Length, typeof(ChildValidator));
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
//			var mockValidatorDescriptor = new Mock<IValidatorDescriptor>();
//			mockValidatorDescriptor
//					.Setup(x => x.GetValidatorsForMember(It.IsAny<string>()))
//					.Returns(new IPropertyValidator[] { new ChildValidatorAdaptor(typeof(ChildValidator)) });

//			var validator = new InlineValidator<TestModel>();
//			validator.AddDescriptor(mockValidatorDescriptor.Object);

//			// Act & Assert
//			validator.ShouldHaveChildValidator(x => x.ChildProperty, typeof(ChildValidator));
//		}
//	}

//	internal class ChildValidatorAdaptor : IChildValidatorAdaptor {
//		public Type ValidatorType { get; }

//		public ChildValidatorAdaptor(Type validatorType) {
//			ValidatorType = validatorType;
//		}
//	}
//}
