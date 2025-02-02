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
//		private HashSet<string> _executedRuleSets;

//		[TestInitialize]
//		public void Setup() {
//			_ruleMock = new Mock<IValidationRule>();
//			_contextMock = new Mock<IValidationContext>();
//			_executedRuleSets = new HashSet<string>();
//			_rootContextData = new Dictionary<string, object>
//			{
//								{ "_FV_RuleSetsExecuted", _executedRuleSets }
//						};
//			_contextMock.Setup(c => c.RootContextData).Returns(_rootContextData);
//		}

//		[TestMethod]
//		public void CanExecute_NoRuleSetsSpecified_NoRuleSetsToExecute_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(Enumerable.Empty<string>());
//			_ruleMock.SetupGet(r => r.RuleSets).Returns((string[])null);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			Assert.IsTrue(_executedRuleSets.Contains(RulesetValidatorSelector.DefaultRuleSetName));
//		}

//		[TestMethod]
//		public void CanExecute_DefaultRuleSetSpecified_MatchingRuleSet_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.DefaultRuleSetName });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { RulesetValidatorSelector.DefaultRuleSetName });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			Assert.IsTrue(_executedRuleSets.Contains(RulesetValidatorSelector.DefaultRuleSetName));
//		}

//		[TestMethod]
//		public void CanExecute_WildcardRuleSetSpecified_ReturnsTrue() {
//			// Arrange
//			var customRuleSet = "CustomRuleSet";
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.WildcardRuleSetName });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { customRuleSet });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			Assert.IsTrue(_executedRuleSets.Contains(customRuleSet));
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
//			Assert.IsFalse(_executedRuleSets.Any());
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
//			CollectionAssert.Contains(_executedRuleSets.ToList(), "ruleset1");
//		}

//		[TestMethod]
//		public void CanExecute_EmptyRuleSetsWithRuleSetsToExecute_ReturnsFalse() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new string[0]);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_WildcardWithEmptyRuleSets_AddsDefaultRuleSet() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.WildcardRuleSetName });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new string[0]);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			Assert.IsTrue(_executedRuleSets.Contains(RulesetValidatorSelector.DefaultRuleSetName));
//		}
//	}
//}
