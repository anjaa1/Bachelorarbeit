//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using Humanizer;

//namespace HumanizerTests {
//    [TestClass]
//    public class EnumHumanizeExtensionsTests {
//        private enum TestEnum {
//            [System.ComponentModel.Description("Value One")]
//            ValueOne,

//            [System.ComponentModel.Description("Value Two")]
//            ValueTwo,

//            ValueThree,
//        }

//        [Flags]
//        private enum FlagsEnum {
//            None = 0,
//            First = 1,
//            Second = 2,
//            Third = 4,
//        }

//        [TestMethod]
//        public void Humanize_ValidEnumValue_ReturnsHumanizedString() {
//            // Arrange
//            var input = TestEnum.ValueOne;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Value One", result);
//        }

//        [TestMethod]
//        public void Humanize_EnumValueWithoutDescription_ReturnsHumanizedName() {
//            // Arrange
//            var input = TestEnum.ValueThree;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Value three", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagEnumValue_ReturnsHumanizedFlags() {
//            // Arrange
//            var input = FlagsEnum.First | FlagsEnum.Second;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("First, Second", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagEnumNone_ReturnsEmptyString() {
//            // Arrange
//            var input = FlagsEnum.None;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void Humanize_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            TestEnum? input = null;

//            // Act
//            _ = input.Humanize();

//            // Assert handled by ExpectedException
//        }

//        [TestMethod]
//        public void Humanize_InvalidEnumType_ThrowsArgumentException() {
//            // Arrange
//            var input = (TestEnum)999;

//            // Act & Assert
//            Assert.ThrowsException<KeyNotFoundException>(() => input.Humanize());
//        }
//    }
//}