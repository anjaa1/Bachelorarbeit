//using System;
//using System.Linq.Expressions;
//using FluentValidation.Internal;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class PropertyChainTests {
//		[TestMethod]
//		public void FromExpression_ShouldHandleSimpleProperty() {
//			// Arrange
//			Expression<Func<TestClass, object>> expression = x => x.SimpleProperty;

//			// Act
//			var result = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.IsNotNull(result, "Result should not be null.");
//			Assert.AreEqual("SimpleProperty", string.Join(".", result.ToString()), "Property name should match.");
//		}

//		[TestMethod]
//		public void FromExpression_ShouldHandleNestedProperty() {
//			// Arrange
//			Expression<Func<TestClass, object>> expression = x => x.NestedProperty.SubProperty;

//			// Act
//			var result = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.IsNotNull(result, "Result should not be null.");
//			Assert.AreEqual("NestedProperty.SubProperty", result.ToString(), "Property chain should match nested structure.");
//		}

//		//[TestMethod]
//		//public void FromExpression_ShouldThrowForNullExpression() {
//		//	// Act & Assert
//		//	try {
//		//		PropertyChain.FromExpression(null);
//		//		Assert.Fail("Expected an ArgumentNullException to be thrown.");
//		//	}
//		//	catch (ArgumentNullException ex) {
//		//		Assert.AreEqual("expression", ex.ParamName, "Parameter name should match.");
//		//	}
//		//}

//		[TestMethod]
//		public void FromExpression_ShouldHandleUnaryExpression() {
//			// Arrange
//			Expression<Func<TestClass, object>> expression = x => (object)x.SimpleProperty;

//			// Act
//			var result = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.IsNotNull(result, "Result should not be null.");
//			Assert.AreEqual("SimpleProperty", result.ToString(), "Property name should match even with a cast.");
//		}

//		[TestMethod]
//		public void FromExpression_ShouldHandleEmptyChain() {
//			// Arrange
//			Expression<Func<TestClass, object>> expression = x => x;

//			// Act
//			var result = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.IsNotNull(result, "Result should not be null.");
//			Assert.AreEqual(string.Empty, result.ToString(), "Property chain should be empty for direct object reference.");
//		}

//		// Helper class for testing
//		private class TestClass {
//			public string SimpleProperty { get; set; }
//			public NestedClass NestedProperty { get; set; }
//		}

//		private class NestedClass {
//			public string SubProperty { get; set; }
//		}
//	}
//}
