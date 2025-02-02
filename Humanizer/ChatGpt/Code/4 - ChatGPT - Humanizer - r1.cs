//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Linq;
//using Humanizer;
//using System.Collections.Generic;

//namespace HumanizerTests {
//    [TestClass]
//    public class EnumHumanizeExtensionsTests {
//        private enum SimpleEnum {
//            [System.ComponentModel.Description("First Value")]
//            FirstValue,

//            [System.ComponentModel.Description("Second Value")]
//            SecondValue,

//            ThirdValue
//        }

//        [Flags]
//        private enum FlagsEnum {
//            None = 0,
//            Flag1 = 1,
//            Flag2 = 2,
//            Flag3 = 4
//        }

//        [TestMethod]
//        public void Humanize_EnumWithDescription_ReturnsDescription() {
//            // Arrange
//            var input = SimpleEnum.FirstValue;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("First Value", result);
//        }

//        [TestMethod]
//        public void Humanize_EnumWithoutDescription_ReturnsHumanizedName() {
//            // Arrange
//            var input = SimpleEnum.ThirdValue;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Third value", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumSingleFlag_ReturnsFlagName() {
//            // Arrange
//            var input = FlagsEnum.Flag1;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Flag1", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumMultipleFlags_ReturnsCombinedNames() {
//            // Arrange
//            var input = FlagsEnum.Flag1 | FlagsEnum.Flag2;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Flag1, Flag2", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumNone_ReturnsEmptyString() {
//            // Arrange
//            var input = FlagsEnum.None;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual(string.Empty, result);
//        }

//        [TestMethod]
//        public void Humanize_InvalidEnumValue_ThrowsKeyNotFoundException() {
//            // Arrange
//            var input = (SimpleEnum)999;

//            // Act & Assert
//            Assert.ThrowsException<KeyNotFoundException>(() => input.Humanize());
//        }

//        [TestMethod]
//        public void Humanize_NullEnum_ThrowsArgumentNullException() {
//            // Arrange
//            SimpleEnum? input = null;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => input.Humanize());
//        }
//    }
//}
