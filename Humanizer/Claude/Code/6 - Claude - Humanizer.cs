//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        [DataRow("I", 1)]
//        [DataRow("II", 2)]
//        [DataRow("III", 3)]
//        [DataRow("IV", 4)]
//        [DataRow("V", 5)]
//        [DataRow("IX", 9)]
//        [DataRow("X", 10)]
//        [DataRow("XL", 40)]
//        [DataRow("L", 50)]
//        [DataRow("XC", 90)]
//        [DataRow("C", 100)]
//        [DataRow("CD", 400)]
//        [DataRow("D", 500)]
//        [DataRow("CM", 900)]
//        [DataRow("M", 1000)]
//        public void FromRoman_ValidNumerals_ReturnsExpectedValue(string input, int expected) {
//            // Arrange
//            var romanNumeral = input.AsSpan();

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [DataRow("MCMLIV", 1954)]
//        [DataRow("MCMXC", 1990)]
//        [DataRow("MMXIV", 2014)]
//        [DataRow("MMMCMXCIX", 3999)]
//        public void FromRoman_ComplexNumerals_ReturnsExpectedValue(string input, int expected) {
//            // Arrange
//            var romanNumeral = input.AsSpan();

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [DataRow("  III  ")]
//        [DataRow("IV  ")]
//        [DataRow("  VI")]
//        public void FromRoman_WhitespacePadding_HandlesCorrectly(string input) {
//            // Arrange
//            var romanNumeral = input.AsSpan();
//            var trimmed = input.Trim();

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(romanNumeral);
//            int expectedResult = RomanNumeralExtensions.FromRoman(trimmed.AsSpan());

//            // Assert
//            Assert.AreEqual(expectedResult, result);
//        }

//        [TestMethod]
//        [DataRow("")]
//        [DataRow("   ")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void FromRoman_EmptyOrWhitespace_ThrowsArgumentException(string input) {
//            // Arrange
//            var romanNumeral = input.AsSpan();

//            // Act
//            RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        [DataRow("ABC")]
//        [DataRow("XIIII")]
//        [DataRow("VV")]
//        [DataRow("IC")]
//        [DataRow("XM")]
//        [DataRow("VC")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void FromRoman_InvalidNumerals_ThrowsArgumentException(string input) {
//            // Arrange
//            var romanNumeral = input.AsSpan();

//            // Act
//            RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        public void FromRoman_MaximumValue_ReturnsExpectedValue() {
//            // Arrange
//            var romanNumeral = "MMMCMXCIX".AsSpan(); // 3999 - maximum valid Roman numeral

//            // Act
//            int result = RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert
//            Assert.AreEqual(3999, result);
//        }

//        [TestMethod]
//        [DataRow("MMMM")] // 4000 - exceeds maximum valid Roman numeral
//        [ExpectedException(typeof(ArgumentException))]
//        public void FromRoman_ExceedsMaximumValue_ThrowsArgumentException(string input) {
//            // Arrange
//            var romanNumeral = input.AsSpan();

//            // Act
//            RomanNumeralExtensions.FromRoman(romanNumeral);

//            // Assert is handled by ExpectedException
//        }
//    }
//}