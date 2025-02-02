//using System;
//using System.Linq.Expressions;
//using System.Reflection;
//using FluentValidation.Internal;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace FluentValidationTests {
//	[TestClass]
//	public class ExtensionsTests {
//		// Helper class for testing
//		private class TestClass {
//			public int IntProperty { get; set; }
//			public string StringProperty { get; set; }
//			public NestedClass NestedProperty { get; set; }
//		}

//		private class NestedClass {
//			public double DoubleProperty { get; set; }
//		}

//		[TestMethod]
//		public void GetMember_ValidSimpleProperty_ReturnsCorrectMemberInfo() {
//			// Arrange
//			Expression<Func<TestClass, int>> expression = x => x.IntProperty;

//			// Act
//			MemberInfo result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("IntProperty", result.Name);
//		}

//		[TestMethod]
//		public void GetMember_ValidNestedProperty_ReturnsCorrectMemberInfo() {
//			// Arrange
//			Expression<Func<TestClass, double>> expression = x => x.NestedProperty.DoubleProperty;

//			// Act
//			MemberInfo result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual("DoubleProperty", result.Name);
//		}

//		[TestMethod]
//		public void GetMember_InvalidExpression_ReturnsNull() {
//			// Arrange
//			Expression<Func<TestClass, int>> expression = x => x.IntProperty + 1;

//			// Act
//			MemberInfo result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_UnaryExpressionWrapper_ReturnsNull() {
//			// Arrange
//			Expression<Func<TestClass, string>> expression = x => x.StringProperty.ToString();

//			// Act
//			MemberInfo result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result, "Should return null since the expression is not a direct property access.");
//		}

//		[TestMethod]
//		public void GetMember_NullExpression_ThrowsArgumentNullException() {
//			// Arrange
//			Expression<Func<TestClass, int>> expression = null;

//			// Act & Assert
//			try {
//				Extensions.GetMember(expression);
//				Assert.Fail("Expected ArgumentNullException not thrown.");
//			}
//			catch (ArgumentNullException ex) {
//				Assert.AreEqual("Value cannot be null. (Parameter 'expression')", ex.Message);
//			}
//		}

//		[TestMethod]
//		public void GetMember_NonParameterExpression_ReturnsNull() {
//			// Arrange
//			Expression<Func<int, int>> expression = x => x + 1;

//			// Act
//			MemberInfo result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result, "Should return null for expressions not acting on model instances.");
//		}
//	}
//}
