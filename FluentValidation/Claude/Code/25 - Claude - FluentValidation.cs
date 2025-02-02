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
//		public void FromExpression_SingleProperty_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Name;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual(1, chain.ToString().Split('.').Length);
//			Assert.AreEqual("Name", chain.ToString());
//		}

//		[TestMethod]
//		public void FromExpression_NestedProperty_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Address.Street;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual(2, chain.ToString().Split('.').Length);
//			Assert.AreEqual("Address.Street", chain.ToString());
//		}

//		[TestMethod]
//		public void FromExpression_DeeplyNestedProperty_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Address.City;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual(3, chain.ToString().Split('.').Length);
//			Assert.AreEqual("Parent.Address.City", chain.ToString());
//		}

//		[TestMethod]
//		[ExpectedException(typeof(ArgumentNullException))]
//		public void FromExpression_NullExpression_ThrowsArgumentNullException() {
//			// Act
//			PropertyChain.FromExpression(null);
//		}

//		[TestMethod]
//		public void FromExpression_WithUnaryExpression_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, object>> expression = p => p.Name;  // This will create a unary expression due to object conversion

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual("Name", chain.ToString());
//		}

//		[TestMethod]
//		public void FromExpression_ComplexNestedPath_PreservesOrder() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Parent.Address.Street;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);
//			var parts = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(4, parts.Length);
//			Assert.AreEqual("Parent", parts[0]);
//			Assert.AreEqual("Parent", parts[1]);
//			Assert.AreEqual("Address", parts[2]);
//			Assert.AreEqual("Street", parts[3]);
//		}

//		[TestMethod]
//		public void FromExpression_NonMemberExpression_ReturnsEmptyChain() {
//			// Arrange
//			Expression<Func<Person, bool>> expression = p => true;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual(string.Empty, chain.ToString());
//		}

//		[TestMethod]
//		public void FromExpression_MethodCall_ReturnsEmptyChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Name.ToString();

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.AreEqual(string.Empty, chain.ToString());
//		}
//	}
//}
