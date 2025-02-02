//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation;
//using FluentValidation.Internal;
//using Moq;
//using System;
//using System.Collections.Generic;

//namespace FluentValidation.Tests {
//	public static class DictionaryExtensions {
//		public static T GetOrAdd<T>(this IDictionary<string, object> dictionary, string key, Func<T> valueFactory) {
//			if (!dictionary.TryGetValue(key, out var value)) {
//				value = valueFactory();
//				dictionary[key] = value;
//			}
//			return (T)value;
//		}
//	}

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
//		public void CanExecute_CaseInsensitiveMatch_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "ruleset1" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "RULESET1" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			var executedRuleSets = (HashSet<string>)_rootContextData["_FV_RuleSetsExecuted"];
//			Assert.IsTrue(executedRuleSets.Contains("ruleset1"));
//		}

//		[TestMethod]
//		public void CanExecute_NoRuleSetsSpecified_NoRuleSetsToExecute_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(Array.Empty<string>());
//			_ruleMock.SetupGet(r => r.RuleSets).Returns((string[])null);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			var executedRuleSets = (HashSet<string>)_rootContextData["_FV_RuleSetsExecuted"];
//			Assert.IsTrue(executedRuleSets.Contains(RulesetValidatorSelector.DefaultRuleSetName));
//		}

//		[TestMethod]
//		public void CanExecute_DefaultRuleSet_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.DefaultRuleSetName });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns((string[])null);

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			var executedRuleSets = (HashSet<string>)_rootContextData["_FV_RuleSetsExecuted"];
//			Assert.IsTrue(executedRuleSets.Contains(RulesetValidatorSelector.DefaultRuleSetName));
//		}

//		[TestMethod]
//		public void CanExecute_WildcardRuleSet_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.WildcardRuleSetName });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "CustomRuleSet" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			var executedRuleSets = (HashSet<string>)_rootContextData["_FV_RuleSetsExecuted"];
//			Assert.IsTrue(executedRuleSets.Contains("CustomRuleSet"));
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
//		public void CanExecute_MultipleRuleSetsWithIntersection_ReturnsTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1", "RuleSet2" });
//			_ruleMock.SetupGet(r => r.RuleSets).Returns(new[] { "RuleSet2", "RuleSet3" });

//			// Act
//			var result = selector.CanExecute(_ruleMock.Object, "propertyPath", _contextMock.Object);

//			// Assert
//			Assert.IsTrue(result);
//			var executedRuleSets = (HashSet<string>)_rootContextData["_FV_RuleSetsExecuted"];
//			Assert.IsTrue(executedRuleSets.Contains("RuleSet2"));
//		}
//	}
//}
