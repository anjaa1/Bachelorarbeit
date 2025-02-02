//using FluentValidation;
//using FluentValidation.TestHelper;
//using FluentValidation.Validators;
//using FluentValidation.Results;
//using FluentValidation.Internal;
//using FluentValidation.TestHelper;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;

//namespace FluentValidation.Testing {
//	[TestClass]
//	public class ValidationTestExtensionTests {
//		[TestMethod]
//		public void ShouldHaveChildValidator_TypicalScenario() {
//			// Arrange
//			var validator = new Validator();
//			var expression = () => validator.Model.Property;
//			var childValidatorType = typeof(ChildValidator);

//			// Act and Assert
//			validator.ShouldHaveChildValidator(expression, childValidatorType);
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_InvalidScenario() {
//			// Arrange
//			var validator = new Validator();
//			var expression = () => validator.Model.Property;
//			var childValidatorType = typeof(InvalidChildValidator);

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => validator.ShouldHaveChildValidator(expression, childValidatorType));
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_MultipleValidatorsScenario() {
//			// Arrange
//			var validator = new Validator();
//			var expression = () => validator.Model.Property;
//			var childValidatorTypes = new[] { typeof(ChildValidator1), typeof(ChildValidator2) };

//			// Act and Assert
//			validator.ShouldHaveChildValidator(expression, childValidatorTypes.First());
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_NullExpressionScenario() {
//			// Arrange
//			var validator = new Validator();
//			var expression = null as Expression<Func<Validator, object>>;
//			var childValidatorType = typeof(ChildValidator);

//			// Act and Assert
//			Assert.ThrowsException<ValidationTestException>(() => validator.ShouldHaveChildValidator(expression, childValidatorType));
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_ParameterExpressionScenario() {
//			// Arrange
//			var validator = new Validator();
//			var expression = (Func<Validator, object>)(() => validator.Model.Property);
//			var childValidatorType = typeof(ChildValidator);

//			// Act and Assert
//			validator.ShouldHaveChildValidator(expression, childValidatorType);
//		}

//		[TestMethod]
//		public void ShouldHaveChildValidator_ParameterExpressionScenario_WithModelLevelValidator() {
//			// Arrange
//			var validator = new Validator();
//			var expression = (Func<Validator, object>)(() => validator.Model.Property);
//			var childValidatorType = typeof(ChildValidator);

//			// Act and Assert
//			validator.ShouldHaveChildValidator(expression, childValidatorType);
//		}
//	}

//	public class Validator : IValidator<Validator> {
//		public ValidatorModel Model { get; set; }

//		public ValidationResult Validate(ValidatorModel model) {
//			return ValidationResult.Success;
//		}

//		public Task<ValidationResult> ValidateAsync(ValidatorModel model, CancellationToken cancellation = default) {
//			return Task.FromResult(ValidationResult.Success);
//		}

//		public IValidatorDescriptor CreateDescriptor() {
//			return new ValidatorDescriptor();
//		}

//		public bool CanValidateInstancesOfType(Type type) {
//			return true;
//		}
//	}

//	public class ValidatorModel {
//		public object Property { get; set; }
//	}

//	public class ChildValidator : IChildValidatorAdaptor {
//		public Type ValidatorType => typeof(ChildValidator);
//	}

//	public class InvalidChildValidator : IChildValidatorAdaptor {
//		public Type ValidatorType => typeof(InvalidChildValidator);
//	}

//	public class ChildValidator1 : IChildValidatorAdaptor {
//		public Type ValidatorType => typeof(ChildValidator1);
//	}

//	public class ChildValidator2 : IChildValidatorAdaptor {
//		public Type ValidatorType => typeof(ChildValidator2);
//	}
//}
