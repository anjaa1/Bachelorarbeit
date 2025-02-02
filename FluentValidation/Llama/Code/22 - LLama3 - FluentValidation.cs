//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Reflection;

//namespace FluentValidation.Tests.Extensions {
//	[TestClass]
//	public class ExtensionsTests {
//		[TestMethod]
//		public void GetMember_TypicalUsage_ReturnsMemberInfo() {
//			// Arrange
//			var model = new TestModel();
//			var expression = (Func<TestModel, string>)x => x.Name;

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual(typeof(TestModel).GetProperty("Name"), result);
//		}

//		[TestMethod]
//		public void GetMember_NullExpression_ReturnsNull() {
//			// Act
//			var result = Extensions.GetMember(null);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_ExpressionWithInvalidMember_ReturnsNull() {
//			// Arrange
//			var model = new TestModel();
//			var expression = (Func<TestModel, string>)x => x.NonExistingProperty;

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_ExpressionWithNestedMember_ReturnsMemberInfo() {
//			// Arrange
//			var model = new NestedModel();
//			var expression = (Func<NestedModel, string>)x => x.Nested.Name;

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual(typeof(NestedModel).GetProperty("Nested").GetProperty("Name"), result);
//		}

//		[TestMethod]
//		public void GetMember_ExpressionWithParameterNotMemberAccess_ReturnsNull() {
//			// Arrange
//			var model = new TestModel();
//			var expression = (Func<TestModel, string>)x => x.ToString();

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_ExpressionWithParameterNotMemberAccessButUnaryOperation_ReturnsNull() {
//			// Arrange
//			var model = new TestModel();
//			var expression = (Func<TestModel, string>)x => (string)x;

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNull(result);
//		}

//		[TestMethod]
//		public void GetMember_ExpressionWithParameterNotMemberAccessButUnaryOperationAndMemberAccess_ReturnsMemberInfo() {
//			// Arrange
//			var model = new TestModel();
//			var expression = (Func<TestModel, string>)x => ((string)x).Name;

//			// Act
//			var result = Extensions.GetMember(expression);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual(typeof(TestModel).GetProperty("Name"), result);
//		}
//	}

//	public class TestModel {
//		public string Name { get; set; }
//	}

//	public class NestedModel {
//		public Nested Nested { get; set; }
//	}

//	public class Nested {
//		public string Name { get; set; }
//	}
//}
