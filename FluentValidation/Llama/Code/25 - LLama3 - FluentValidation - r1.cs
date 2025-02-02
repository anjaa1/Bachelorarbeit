//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using FluentValidation.Internal;

//namespace FluentValidation.Tests {
//	[TestClass]
//	public class PropertyChainTests {
//		[TestMethod]
//		public void FromExpression_TypicalUsage_ReturnsPropertyChain() {
//			// Arrange
//			var propertyChain = PropertyChain.FromExpression(Expression.Lambda(Expression.Property(Expression.Parameter(typeof(MyObject), "MyObject"), "MyProperty"), Expression.Parameter(typeof(MyObject), "MyObject")));

//			// Act
//			var actual = propertyChain.MemberNames;

//			// Assert
//			Assert.AreEqual(new[] { "MyProperty", "MyObject" }, actual);
//		}

//		[TestMethod]
//		public void FromExpression_EdgeCase_EmptyExpression_ReturnsPropertyChain() {
//			// Arrange
//			var propertyChain = PropertyChain.FromExpression(Expression.Lambda(Expression.Constant(1), Expression.Parameter(typeof(MyObject), "MyObject")));

//			// Act
//			var actual = propertyChain.MemberNames;

//			// Assert
//			Assert.AreEqual(new string[0], actual);
//		}

//		[TestMethod]
//		[ExpectedException(typeof(NullReferenceException))]
//		public void FromExpression_NullExpression_Throws() {
//			// Arrange
//			var propertyChain = PropertyChain.FromExpression(null);

//			// Act
//			// Assert
//		}

//		[TestMethod]
//		public void FromExpression_InvalidExpression_DoesNotThrow() {
//			// Arrange
//			var propertyChain = PropertyChain.FromExpression(Expression.Lambda(Expression.Call(Expression.Constant(1), "ToString"), Expression.Parameter(typeof(MyObject), "MyObject")));

//			// Act
//			var actual = propertyChain.MemberNames;

//			// Assert
//			Assert.AreEqual(new string[0], actual);
//		}
//	}

//	public class PropertyChain {
//		public List<string> MemberNames { get; } = new(2);

//		// Rest of the class remains the same
//	}
//}
