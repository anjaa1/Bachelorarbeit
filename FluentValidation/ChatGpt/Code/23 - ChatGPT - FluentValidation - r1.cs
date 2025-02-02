//using System;
//using System.Collections.Generic;
//using FluentValidation;
//using FluentValidation.Internal;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class MemberNameValidatorSelectorTests {
//		[TestMethod]
//		public void CanExecute_ReturnsTrue_ForMatchingPropertyPath() {
//			// Arrange
//			var memberNames = new List<string> { "Customer.Name" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockRule = new Mock<IValidationRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(false);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object>());

//			// Act
//			bool result = selector.CanExecute(mockRule.Object, "Customer.Name", mockContext.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ReturnsFalse_ForNonMatchingPropertyPath() {
//			// Arrange
//			var memberNames = new List<string> { "Customer.Address" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockRule = new Mock<IValidationRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(false);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object>());

//			// Act
//			bool result = selector.CanExecute(mockRule.Object, "Customer.Name", mockContext.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_ReturnsTrue_ForChildContextWithCascadeEnabled() {
//			// Arrange
//			var memberNames = new List<string> { "Orders[].Name" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockRule = new Mock<IValidationRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(true);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object>());

//			// Act
//			bool result = selector.CanExecute(mockRule.Object, "Orders[0].Name", mockContext.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ReturnsTrue_ForIncludeRule() {
//			// Arrange
//			var memberNames = new List<string> { "Customer.Name" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockIncludeRule = new Mock<IValidationRule>();
//			mockIncludeRule.As<IIncludeRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(false);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object>());

//			// Act
//			bool result = selector.CanExecute(mockIncludeRule.Object, "Customer.Name", mockContext.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ReturnsFalse_WhenCascadeDisabled() {
//			// Arrange
//			var memberNames = new List<string> { "Customer.Name" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockRule = new Mock<IValidationRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(true);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object> {
//								{ MemberNameValidatorSelector.DisableCascadeKey, true }
//						});

//			// Act
//			bool result = selector.CanExecute(mockRule.Object, "Customer.Name", mockContext.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_HandlesNormalizedCollectionPaths() {
//			// Arrange
//			var memberNames = new List<string> { "Orders[].Amount" };
//			var selector = new MemberNameValidatorSelector(memberNames);

//			var mockRule = new Mock<IValidationRule>();
//			var mockContext = new Mock<IValidationContext>();
//			mockContext.Setup(c => c.IsChildContext).Returns(false);
//			mockContext.Setup(c => c.RootContextData).Returns(new Dictionary<string, object>());

//			// Act
//			bool result = selector.CanExecute(mockRule.Object, "Orders[0].Amount", mockContext.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}
//	}
//}
