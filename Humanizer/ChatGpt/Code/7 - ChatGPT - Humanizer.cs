//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace HumanizerTests {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        public void ToRoman_ValidInput_ReturnsCorrectRomanNumeral() {
//            // Arrange
//            var testCases = new (int input, string expected)[]
//            {
//                (1, "I"),
//                (4, "IV"),
//                (9, "IX"),
//                (40, "XL"),
//                (90, "XC"),
//                (400, "CD"),
//                (900, "CM"),
//                (3999, "MMMCMXCIX")
//            };

//            // Act & Assert
//            foreach (var testCase in testCases) {
//                var result = testCase.input.ToRoman();
//                Assert.AreEqual(testCase.expected, result, $"Failed for input: {testCase.input}");
//            }
//        }

//        [TestMethod]
//        public void ToRoman_InputBelowRange_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            var input = 0;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman(), "Expected ArgumentOutOfRangeException for input below range.");
//        }

//        [TestMethod]
//        public void ToRoman_InputAboveRange_ThrowsArgumentOutOfRangeException() {
//            // Arrange
//            var input = 4000;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman(), "Expected ArgumentOutOfRangeException for input above range.");
//        }

//        [TestMethod]
//        public void ToRoman_EdgeCase_MinimumValue_ReturnsI() {
//            // Arrange
//            var input = 1;
//            var expected = "I";

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void ToRoman_EdgeCase_MaximumValue_ReturnsMMMCMXCIX() {
//            // Arrange
//            var input = 3999;
//            var expected = "MMMCMXCIX";

//            // Act
//            var result = input.ToRoman();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }
//    }
//}
