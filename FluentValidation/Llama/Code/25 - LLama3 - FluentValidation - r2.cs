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

//	public class MyObject {
//		public string MyProperty { get; set; }
//	}

//	public class PropertyChain {
//		public List<string> MemberNames { get; } = new(2);

//		/// <summary>
//		/// Creates a new PropertyChain
//		/// </summary>
//		/// <param name="memberNames"></param>
//		public PropertyChain(IEnumerable<string> memberNames) {
//			this.MemberNames.AddRange(memberNames);
//		}

//		/// <summary>
//		/// Creates a PropertyChain from a lambda expression
//		/// </summary>
//		/// <param name="expression"></param>
//		/// <returns></returns>
//		public static PropertyChain FromExpression(LambdaExpression expression) {
//			if (expression == null) {
//				throw new NullReferenceException();
//			}

//			var memberNames = new Stack<string>();

//			var getMemberExp = new Func<Expression, MemberExpression>(toUnwrap => {
//				if (toUnwrap is UnaryExpression) {
//					return ((UnaryExpression)toUnwrap).Operand as MemberExpression;
//				}

//				return toUnwrap as MemberExpression;
//			});

//			var memberExp = getMemberExp(expression.Body);

//			while (memberExp != null) {
//				memberNames.Push(memberExp.Member.Name);
//				memberExp = getMemberExp(memberExp.Expression);
//			}

//			return new PropertyChain(memberNames);
//		}
//	}
//}
