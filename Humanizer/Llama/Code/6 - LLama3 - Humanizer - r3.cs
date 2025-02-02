//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Diagnostics;

//namespace Humanizer.Test {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        public void FromRoman_ValidInput_ReturnsCorrectValue() {
//            // Arrange
//            var input = new CharSpan("XII");

//            // Act
//            var result = RomanNumeralExtensions.FromRoman(input);

//            // Assert
//            Assert.AreEqual(12, result);
//        }

//        [TestMethod]
//        public void FromRoman_InvalidInput_ThrowsArgumentException() {
//            // Arrange
//            var input = new CharSpan("");

//            // Act and Assert
//            var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumeralExtensions.FromRoman(input));
//            Assert.AreEqual("Empty or invalid Roman numeral string.", ex.Message);
//        }

//        [TestMethod]
//        public void FromRoman_EmptyInput_ThrowsArgumentException() {
//            // Arrange
//            var input = new CharSpan("   ");

//            // Act and Assert
//            var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumeralExtensions.FromRoman(input));
//            Assert.AreEqual("Empty or invalid Roman numeral string.", ex.Message);
//        }

//        [TestMethod]
//        public void FromRoman_NullInput_ThrowsArgumentException() {
//            // Arrange
//            var input = (CharSpan)null;

//            // Act and Assert
//            var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumeralExtensions.FromRoman(input));
//            Assert.AreEqual("Empty or invalid Roman numeral string.", ex.Message);
//        }

//        [TestMethod]
//        public void FromRoman_TypicalCase_ReturnsCorrectValue() {
//            // Arrange
//            var input = new CharSpan("MCMXCIX");

//            // Act
//            var result = RomanNumeralExtensions.FromRoman(input);

//            // Assert
//            Assert.AreEqual(1999, result);
//        }

//        [TestMethod]
//        public void FromRoman_EdgeCase_ReturnsCorrectValue() {
//            // Arrange
//            var input = new CharSpan("I");

//            // Act
//            var result = RomanNumeralExtensions.FromRoman(input);

//            // Assert
//            Assert.AreEqual(1, result);
//        }

//        [TestMethod]
//        public void FromRoman_InvalidRomanNumeral_ThrowsArgumentException() {
//            // Arrange
//            var input = new CharSpan("Invalid");

//            // Act and Assert
//            var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumeralExtensions.FromRoman(input));
//            Assert.AreEqual("Empty or invalid Roman numeral string.", ex.Message);
//        }
//    }
//}