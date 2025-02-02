//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Internal;
//using FluentValidation;
//using System.Collections.Generic;
//using System.Linq;

//namespace FluentValidationTests {
//	[TestClass]
//	public class RulesetValidatorSelectorTests {
//		private class MockValidationRule : IValidationRule {
//			public IEnumerable<IRuleComponent> Components => Enumerable.Empty<IRuleComponent>();
//			public string[] RuleSets { get; set; } = new string[0];
//			public string PropertyName { get; set; }
//			public System.Reflection.MemberInfo Member => null;
//			public System.Type TypeToValidate => typeof(object);
//			public bool HasCondition => false;
//			public bool HasAsyncCondition => false;
//			public System.Linq.Expressions.LambdaExpression Expression => null;
//			public IEnumerable<IValidationRule> DependentRules => Enumerable.Empty<IValidationRule>();

//			public string GetDisplayName(IValidationContext context) => PropertyName;
//		}

//		private class MockValidationContext : IValidationContext {
//			public object InstanceToValidate => new object();
//			public IDictionary<string, object> RootContextData { get; } = new Dictionary<string, object>();
//			public PropertyChain PropertyChain => new PropertyChain();
//			public IValidatorSelector Selector => null;
//			public bool IsChildContext => false;
//			public bool IsChildCollectionContext => false;
//			public IValidationContext ParentContext => null;
//			public bool IsAsync => false;
//			public bool ThrowOnFailures => false;
//		}

//		[TestMethod]
//		public void CanExecute_DefaultRuleSet_ShouldReturnTrueWhenRuleSetIsDefaultAndEmpty() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.DefaultRuleSetName });
//			var rule = new MockValidationRule();
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ExplicitRuleSet_ShouldReturnTrueWhenRuleSetMatches() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "CustomRuleSet" });
//			var rule = new MockValidationRule { RuleSets = new[] { "CustomRuleSet" } };
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_ExplicitRuleSet_ShouldReturnFalseWhenRuleSetDoesNotMatch() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "AnotherRuleSet" });
//			var rule = new MockValidationRule { RuleSets = new[] { "CustomRuleSet" } };
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsFalse(result);
//		}

//		[TestMethod]
//		public void CanExecute_WildcardRuleSet_ShouldReturnTrueForAnyRuleSet() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { RulesetValidatorSelector.WildcardRuleSetName });
//			var rule = new MockValidationRule { RuleSets = new[] { "RandomRuleSet" } };
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_EmptyRuleSetAndDefaultSelected_ShouldReturnTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new string[0]);
//			var rule = new MockValidationRule();
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_MultipleMatchingRuleSets_ShouldReturnTrue() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1", "RuleSet2" });
//			var rule = new MockValidationRule { RuleSets = new[] { "RuleSet2", "RuleSet3" } };
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsTrue(result);
//		}

//		[TestMethod]
//		public void CanExecute_MultipleNonMatchingRuleSets_ShouldReturnFalse() {
//			// Arrange
//			var selector = new RulesetValidatorSelector(new[] { "RuleSet1", "RuleSet2" });
//			var rule = new MockValidationRule { RuleSets = new[] { "RuleSet3", "RuleSet4" } };
//			var context = new MockValidationContext();

//			// Act
//			var result = selector.CanExecute(rule, null, context);

//			// Assert
//			Assert.IsFalse(result);
//		}
//	}
//}
