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
//			var memberNames = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(1, memberNames.Length);
//			Assert.AreEqual("Name", memberNames[0]);
//		}

//		[TestMethod]
//		public void FromExpression_NestedProperty_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Address.Street;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);
//			var memberNames = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(2, memberNames.Length);
//			Assert.AreEqual("Address", memberNames[0]);
//			Assert.AreEqual("Street", memberNames[1]);
//		}

//		[TestMethod]
//		public void FromExpression_DeeplyNestedProperty_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Address.City;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);
//			var memberNames = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(3, memberNames.Length);
//			Assert.AreEqual("Parent", memberNames[0]);
//			Assert.AreEqual("Address", memberNames[1]);
//			Assert.AreEqual("City", memberNames[2]);
//		}

//		[TestMethod]
//		public void FromExpression_WithUnaryExpression_ReturnsCorrectChain() {
//			// Arrange
//			Expression<Func<Person, object>> expression = p => p.Name;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);
//			var memberNames = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(1, memberNames.Length);
//			Assert.AreEqual("Name", memberNames[0]);
//		}

//		[TestMethod]
//		public void FromExpression_ComplexNestedPath_PreservesOrder() {
//			// Arrange
//			Expression<Func<Person, string>> expression = p => p.Parent.Parent.Address.Street;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);
//			var memberNames = chain.ToString().Split('.');

//			// Assert
//			Assert.AreEqual(4, memberNames.Length);
//			Assert.AreEqual("Parent", memberNames[0]);
//			Assert.AreEqual("Parent", memberNames[1]);
//			Assert.AreEqual("Address", memberNames[2]);
//			Assert.AreEqual("Street", memberNames[3]);
//		}

//		[TestMethod]
//		public void FromExpression_NullExpression_ReturnsEmptyChain() {
//			// Act
//			var chain = PropertyChain.FromExpression(null);

//			// Assert
//			Assert.IsNotNull(chain);
//			Assert.AreEqual(string.Empty, chain.ToString());
//		}

//		[TestMethod]
//		public void FromExpression_NonMemberExpression_ReturnsEmptyChain() {
//			// Arrange
//			Expression<Func<Person, bool>> expression = p => true;

//			// Act
//			var chain = PropertyChain.FromExpression(expression);

//			// Assert
//			Assert.IsNotNull(chain);
//			Assert.AreEqual(string.Empty, chain.ToString());
//		}
//	}
//}
