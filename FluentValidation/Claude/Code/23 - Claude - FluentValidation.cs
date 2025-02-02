//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Internal;
//using Moq;
//using System.Collections.Generic;

//namespace FluentValidation.Tests.Internal {
//	[TestClass]
//	public class MemberNameValidatorSelectorTests {
//		private Mock<IValidationContext> _contextMock;
//		private Mock<IValidationRule> _ruleMock;
//		private Dictionary<string, object> _contextData;

//		[TestInitialize]
//		public void Setup() {
//			_contextMock = new Mock<IValidationContext>();
//			_ruleMock = new Mock<IValidationRule>();
//			_contextData = new Dictionary<string, object>();

//			_contextMock.Setup(x => x.RootContextData).Returns(_contextData);
//		}

//		[TestMethod]
//		public void CanExecute_ExactPropertyNameMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Name" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Name", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ChildPropertyMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Address" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Address.Street", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ParentPropertyMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Address.Street" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Address", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_CollectionPropertyMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Orders[0].Amount" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Orders", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_WildcardCollectionMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Orders[].Amount" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Orders[0].Amount", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_NoMatch_ReturnsFalse() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Name" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Age", _contextMock.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_IncludeRule_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Name" });
//			var includeRuleMock = new Mock<IValidationRule>();
//			includeRuleMock.As<IIncludeRule>();

//			// Act
//			var result = selector.CanExecute(includeRuleMock.Object, "AnyProperty", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ChildContextWithCascadeEnabled_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Name" });
//			_contextMock.Setup(x => x.IsChildContext).Returns(true);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "AnyProperty", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ChildContextWithCascadeDisabled_ReturnsFalse() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Name" });
//			_contextMock.Setup(x => x.IsChildContext).Returns(true);
//			_contextData[MemberNameValidatorSelector.DisableCascadeKey] = true;

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "AnyProperty", _contextMock.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_ChildContextWithNestedPropertySelector_ReturnsTrue() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new[] { "Parent.Child" });
//			_contextMock.Setup(x => x.IsChildContext).Returns(true);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "Parent.Child", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_EmptyMemberNames_ReturnsFalse() {
//			// Arrange
//			var selector = new MemberNameValidatorSelector(new string[] { });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "AnyProperty", _contextMock.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}
//	}
//}
