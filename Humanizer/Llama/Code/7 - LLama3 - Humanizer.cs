//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        public void ToRoman_ValidInput_ReturnsCorrectRomanRepresentation() {
//            // Arrange
//            var input = 1234;

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual("MCCXXXIV", result);
//        }

//        [TestMethod]
//        public void ToRoman_EdgeCaseInput_ReturnsCorrectRomanRepresentation() {
//            // Arrange
//            var input = 1;

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual("I", result);
//        }

//        [TestMethod]
//        public void ToRoman_MaxValueInput_ReturnsCorrectRomanRepresentation() {
//            // Arrange
//            var input = 3999;

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual("MMMCMXCIX", result);
//        }

//        [TestMethod]
//        public void ToRoman_MinValueInput_ReturnsCorrectRomanRepresentation() {
//            // Arrange
//            var input = 1;

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual("I", result);
//        }

//        [TestMethod]
//        public void ToRoman_InvalidInput_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            var input = 0;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman());
//        }

//        [TestMethod]
//        public void ToRoman_NegativeInput_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            var input = -1;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman());
//        }

//        [TestMethod]
//        public void ToRoman_LargeInput_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            var input = 4000;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman());
//        }

//        [TestMethod]
//        public void ToRoman_NullInput_ThrowsNullReferenceException() {
//            // Arrange
//            var input = null;

//            // Act and Assert
//            Assert.ThrowsException<NullReferenceException>(() => input.ToRoman());
//        }
//    }
//}