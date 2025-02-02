//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class RomanNumeralExtensionsTests {
//        [TestMethod]
//        [Description("Validates basic number to Roman numeral conversions")]
//        [DataRow(1, "I")]
//        [DataRow(2, "II")]
//        [DataRow(3, "III")]
//        [DataRow(4, "IV")]
//        [DataRow(5, "V")]
//        [DataRow(9, "IX")]
//        [DataRow(10, "X")]
//        [DataRow(40, "XL")]
//        [DataRow(50, "L")]
//        [DataRow(90, "XC")]
//        [DataRow(100, "C")]
//        [DataRow(400, "CD")]
//        [DataRow(500, "D")]
//        [DataRow(900, "CM")]
//        [DataRow(1000, "M")]
//        public void ToRoman_BasicConversions_ReturnsExpectedResult(int input, string expected) {
//            // Act
//            string result = input.ToRoman();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [Description("Validates complex number to Roman numeral conversions")]
//        [DataRow(14, "XIV")]
//        [DataRow(44, "XLIV")]
//        [DataRow(99, "XCIX")]
//        [DataRow(437, "CDXXXVII")]
//        [DataRow(999, "CMXCIX")]
//        [DataRow(2023, "MMXXIII")]
//        [DataRow(3549, "MMMDXLIX")]
//        [DataRow(3999, "MMMCMXCIX")]
//        public void ToRoman_ComplexNumbers_ReturnsExpectedResult(int input, string expected) {
//            // Act
//            string result = input.ToRoman();

//            // Assert
//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [Description("Validates edge cases for minimum and maximum valid values")]
//        public void ToRoman_EdgeCases_HandlesCorrectly() {
//            // Arrange & Act & Assert
//            Assert.AreEqual("I", 1.ToRoman(), "Minimum value (1) should convert to 'I'");
//            Assert.AreEqual("MMMCMXCIX", 3999.ToRoman(), "Maximum value (3999) should convert to 'MMMCMXCIX'");
//        }

//        [TestMethod]
//        [Description("Validates that invalid inputs throw ArgumentOutOfRangeException")]
//        [DataRow(0)]
//        [DataRow(-1)]
//        [DataRow(-42)]
//        [DataRow(4000)]
//        [DataRow(5000)]
//        [DataRow(int.MinValue)]
//        [DataRow(int.MaxValue)]
//        public void ToRoman_InvalidInput_ThrowsArgumentOutOfRangeException(int input) {
//            // Act & Assert
//            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.ToRoman());
//        }

//        [TestMethod]
//        [Description("Validates that subsequent calls with the same input produce consistent results")]
//        public void ToRoman_ConsistentResults_MultipleCallsSameInput() {
//            // Arrange
//            const int testValue = 2024;

//            // Act
//            string result1 = testValue.ToRoman();
//            string result2 = testValue.ToRoman();
//            string result3 = testValue.ToRoman();

//            // Assert
//            Assert.AreEqual(result1, result2, "First and second calls should produce the same result");
//            Assert.AreEqual(result2, result3, "Second and third calls should produce the same result");
//        }
//    }
//}