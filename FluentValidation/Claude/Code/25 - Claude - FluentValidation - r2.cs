//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Linq;
//using System.Linq.Expressions;
//using FluentValidation.Internal;

//namespace FluentValidation.Tests.Internal {
//	[TestClass]
//	public class PropertyChainTests {
//		// Test models
//		private class Address {
//			public string Street { get; set; }
//			public string City { get; set; }
//		}

//		private class Person {
//			public string Name { get; set; }
//			public Address Address { get; set; }
//			public Person Parent { get; set; }
//		}

//		[TestMethod]
//		[ExpectedException(typeof(NullReferenceException))]
//		public void FromExpression_NullExpression_ThrowsNullReferenceException() {
//			// Act
//			PropertyChain.FromExpression(null);
//		}

//		[TestMethod]
//		public void FromExpression_SingleProperty_ReturnsCorrectPropertyChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Name;

//			// Act
//			var propertyChain = PropertyChain.FromExpression(expression);

//			// Assert
//			CollectionAssert.AreEqual(new[] { "Name" }, propertyChain.ToString().Split('.'));
//		}

//		[TestMethod]
//		public void FromExpression_NestedProperty_ReturnsCorrectPropertyChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Address.Street;

//			// Act
//			var propertyChain = PropertyChain.FromExpression(expression);

//			// Assert
//			CollectionAssert.AreEqual(new[] { "Address", "Street" }, propertyChain.ToString().Split('.'));
//		}

//		[TestMethod]
//		public void FromExpression_DeeplyNestedProperty_ReturnsCorrectPropertyChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Address.City;

//			// Act
//			var propertyChain = PropertyChain.FromExpression(expression);

//			// Assert
//			CollectionAssert.AreEqual(new[] { "Parent", "Address", "City" }, propertyChain.ToString().Split('.'));
//		}

//		[TestMethod]
//		public void FromExpression_UnaryExpression_ReturnsCorrectPropertyChain() {
//			// Arrange
//			Expression<Func<Person, object>> expression = p => p.Name;  // This creates a unary expression due to boxing

//			// Act
//			var propertyChain = PropertyChain.FromExpression(expression);

//			// Assert
//			CollectionAssert.AreEqual(new[] { "Name" }, propertyChain.ToString().Split('.'));
//		}

//		[TestMethod]
//		public void FromExpression_MultiLevelNesting_ReturnsCorrectPropertyChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Parent.Address.Street;

//			// Act
//			var propertyChain = PropertyChain.FromExpression(expression);

//			// Assert
//			CollectionAssert.AreEqual(
//					new[] { "Parent", "Parent", "Address", "Street" },
//					propertyChain.ToString().Split('.')
//			);
//		}
//	}
//}
