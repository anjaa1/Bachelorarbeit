//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Internal;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class RulesetValidatorSelectorTests {
//		private Mock<IValidationRule> _ruleMock;
//		private Mock<IValidationContext> _contextMock;
//		private Dictionary<string, object> _rootContextData;

//		[TestInitialize]
//		public void Setup() {
//			_ruleMock = new Mock<IValidationRule>();
//			_contextMock = new Mock<IValidationContext>();
//			_rootContextData = new Dictionary<string, object>();
//			_contextMock.Setup(c => c.RootContextData).Returns(_rootContextData);
//		}

//		[TestMethod]
//		public void CanExecute_EmptyRuleSetsAndNoRuleSetsToExecute_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(Array.Empty<string>());
//			_ruleMock.SetupGet(r => r.RuleSets).Returns((string[])null);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_DefaultRuleSetSpecified_MatchingDefaultRuleSet_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "default" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "default" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_DefaultRuleSetSpecified_NoRuleSetsOnRule_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "default" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns((string[])null);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_WildcardSpecified_AnyRuleSet_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "*" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "CustomRuleSet" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_RuleSetsWithIntersection_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1", "RuleSet2" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "RuleSet2", "RuleSet3" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_NoMatchingRuleSets_ReturnsFalse() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "RuleSet2" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_CaseInsensitiveMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "ruleset1" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "RULESET1" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//		}
//	}
//}
