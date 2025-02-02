//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Linq.Expressions;
//using FluentValidation.Internal;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class ExtensionsTests {
//		// Test class to use in our tests
//		private class TestClass {
//			public string StringProperty { get; set; }
//			public int IntProperty { get; set; }
//			public NestedClass NestedProperty { get; set; }
//		}

//		private class NestedClass {
//			public string NestedStringProperty { get; set; }
//		}

//		[TestMethod]
//		public void GetMember_SimpleProperty_ReturnsPropertyInfo() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => x.StringProperty;

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("StringProperty", result.Name);
//			Assert.AreEqual(typeof(string), ((System.Reflection.PropertyInfo)result).PropertyType);
//		}

//		[TestMethod]
//		public void GetMember_NestedProperty_ReturnsNestedPropertyInfo() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => x.NestedProperty.NestedStringProperty;

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("NestedStringProperty", result.Name);
//			Assert.AreEqual(typeof(string), ((System.Reflection.PropertyInfo)result).PropertyType);
//		}

//		[TestMethod]
//		public void GetMember_NonMemberExpression_ReturnsNull() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => "Constant";

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_ComplexExpression_ReturnsNull() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => x.StringProperty + "suffix";

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_StaticMember_ReturnsNull() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => string.Empty;

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_DifferentTypes_HandlesCorrectly() {
//			// Arrange
//			Expression<Func<TestClass, int>> expression = x => x.IntProperty;

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("IntProperty", result.Name);
//			Assert.AreEqual(typeof(int), ((System.Reflection.PropertyInfo)result).PropertyType);
//		}

//		[TestMethod]
//		public void GetMember_NullableProperty_HandlesCorrectly() {
//			// Arrange
//			Expression<Func<TestClass, int?>> expression = x => (int?)x.IntProperty;

//			// Act
//			var result = expression.GetMember();

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("IntProperty", result.Name);
//			Assert.AreEqual(typeof(int), ((System.Reflection.PropertyInfo)result).PropertyType);
//		}
//	}
//}
