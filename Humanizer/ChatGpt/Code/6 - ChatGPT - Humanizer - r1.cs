//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer; // Assuming the namespace contains the RomanNumeralExtensions class

//namespace RomanNumeralExtensionsTests {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        [DataRow("I", 1)]
//        [DataRow("V", 5)]
//        [DataRow("X", 10)]
//        [DataRow("L", 50)]
//        [DataRow("C", 100)]
//        [DataRow("D", 500)]
//        [DataRow("M", 1000)]
//        [DataRow("IV", 4)]
//        [DataRow("IX", 9)]
//        [DataRow("XL", 40)]
//        [DataRow("XC", 90)]
//        [DataRow("CD", 400)]
//        [DataRow("CM", 900)]
//        [DataRow("MMXXV", 2025)] // Complex case
//        public void FromRoman_ValidInput_ReturnsExpectedValue(string roman, int expected) {
//            // Act
//            int result = RomanNumeralExtensions.FromRoman(roman.AsSpan());

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [DataRow("IIII")] // Invalid repeated numeral
//        [DataRow("VV")] // Invalid repeated V
//        [DataRow("IC")] // Invalid subtractive notation
//        [DataRow("ABCD")] // Invalid characters
//        [DataRow("")] // Empty string
//        public void FromRoman_InvalidInput_ThrowsArgumentException(string roman) {
//            // Act & Assert
//            Assert.ThrowsException<ArgumentException>(() => RomanNumeralExtensions.FromRoman(roman.AsSpan()));
//        }

//        [TestMethod]
//        public void FromRoman_WhitespaceInput_HandlesCorrectly() {
//            // Arrange
//            string input = "  MMXXV  ";
//            int expected = 2025;

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(input.AsSpan());

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void FromRoman_CaseInsensitiveInput_HandlesCorrectly() {
//            // Arrange
//            string input = "MMXXV"; // Mixed case input
//            int expected = 2025;

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(input.AsSpan());

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void FromRoman_SingleCharacterInput_ReturnsCorrectValue() {
//            // Arrange
//            string input = "M";
//            int expected = 1000;

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(input.AsSpan());

//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//    }
//}
