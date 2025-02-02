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
//            SimpleEnum input = SimpleEnum.FirstValue;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("First Value", result);
//        }

//        [TestMethod]
//        public void Humanize_EnumWithoutDescription_ReturnsHumanizedName() {
//            // Arrange
//            SimpleEnum input = SimpleEnum.ThirdValue;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Third value", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumSingleFlag_ReturnsFlagName() {
//            // Arrange
//            FlagsEnum input = FlagsEnum.Flag1;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Flag 1", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumMultipleFlags_ReturnsCombinedNames() {
//            // Arrange
//            FlagsEnum input = FlagsEnum.Flag1 | FlagsEnum.Flag2;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("Flag 1 and Flag 2", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnumNone_ReturnsNoneString() {
//            // Arrange
//            FlagsEnum input = FlagsEnum.None;

//            // Act
//            var result = input.Humanize();

//            // Assert
//            Assert.AreEqual("None", result);
//        }

//        [TestMethod]
//        public void Humanize_InvalidEnumValue_ThrowsKeyNotFoundException() {
//            // Arrange
//            SimpleEnum input = (SimpleEnum)999;

//            // Act & Assert
//            Assert.ThrowsException<KeyNotFoundException>(() => input.Humanize());
//        }
//    }
//}
