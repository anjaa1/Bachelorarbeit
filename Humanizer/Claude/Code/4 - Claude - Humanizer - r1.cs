//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
//using System.Collections.Frozen;
//using System.Collections.Generic;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumHumanizeExtensionsTests {
//        // Test enums
//        private enum TestEnum {
//            FirstValue,
//            SecondValue,
//            [Description("Custom Description")]
//            ThirdValue,
//            FourthValueWithCamelCase
//        }

//        [Flags]
//        private enum TestFlagsEnum {
//            None = 0,
//            First = 1,
//            Second = 2,
//            Third = 4,
//            All = First | Second | Third
//        }

//        [TestMethod]
//        public void Humanize_SimpleEnum_ReturnsHumanizedString() {
//            // Arrange
//            var value = TestEnum.FirstValue;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First value", result);
//        }

//        [TestMethod]
//        public void Humanize_EnumWithDescription_ReturnsDescription() {
//            // Arrange
//            var value = TestEnum.ThirdValue;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("Custom Description", result);
//        }

//        [TestMethod]
//        public void Humanize_CamelCaseEnum_ReturnsSpacedString() {
//            // Arrange
//            var value = TestEnum.FourthValueWithCamelCase;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("Fourth value with camel case", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnum_SingleFlag_ReturnsHumanizedString() {
//            // Arrange
//            var value = TestFlagsEnum.First;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnum_MultipleFlags_ReturnsCommaSeparatedString() {
//            // Arrange
//            var value = TestFlagsEnum.First | TestFlagsEnum.Second;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First and Second", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnum_AllFlags_ReturnsAllValues() {
//            // Arrange
//            var value = TestFlagsEnum.All;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First, Second and Third", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnum_None_ReturnsNone() {
//            // Arrange
//            var value = TestFlagsEnum.None;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("None", result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(KeyNotFoundException))]
//        public void Humanize_InvalidEnumValue_ThrowsKeyNotFoundException() {
//            // Arrange
//            TestEnum invalidValue = (TestEnum)999;

//            // Act & Assert
//            _ = invalidValue.Humanize();
//        }

//        [TestMethod]
//        public void Humanize_DifferentEnumValues_ReturnsDifferentResults() {
//            // Arrange
//            var value1 = TestEnum.FirstValue;
//            var value2 = TestEnum.SecondValue;

//            // Act
//            var result1 = value1.Humanize();
//            var result2 = value2.Humanize();

//            // Assert
//            Assert.AreNotEqual(result1, result2);
//        }

//        [TestMethod]
//        public void Humanize_SameEnumValue_ReturnsCachedResult() {
//            // Arrange
//            var value = TestEnum.FirstValue;

//            // Act
//            var result1 = value.Humanize();
//            var result2 = value.Humanize();

//            // Assert
//            Assert.AreEqual(result1, result2);
//        }
//    }
//}