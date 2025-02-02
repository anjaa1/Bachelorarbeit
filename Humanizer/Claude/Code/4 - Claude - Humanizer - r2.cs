//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
//using System.Collections.Frozen;
//using System.Collections.Generic;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumHumanizeExtensionsTests {
//        private enum TestEnum {
//            [Description("First Value Description")]
//            FirstValue,
//            SecondValue,
//            [Description("Custom Description")]
//            ThirdValue
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
//            var value = TestEnum.SecondValue;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("Second value", result);
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
//        public void Humanize_FlagsEnum_SingleFlag_ReturnsHumanizedString() {
//            // Arrange
//            var value = TestFlagsEnum.First;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First", result);
//        }

//        [TestMethod]
//        public void Humanize_FlagsEnum_MultipleFlags_ReturnsCombinedString() {
//            // Arrange
//            var value = TestFlagsEnum.First | TestFlagsEnum.Second;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First, Second", result);
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
//        public void Humanize_FlagsEnum_All_ReturnsCombinedString() {
//            // Arrange
//            var value = TestFlagsEnum.All;

//            // Act
//            var result = value.Humanize();

//            // Assert
//            Assert.AreEqual("First, Second, Third", result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(KeyNotFoundException))]
//        public void Humanize_InvalidEnumValue_ThrowsException() {
//            // Arrange
//            TestEnum invalidValue = (TestEnum)999;

//            // Act & Assert
//            _ = invalidValue.Humanize();
//        }

//        [TestMethod]
//        public void Humanize_MultipleCallsOnSameValue_ReturnsSameResult() {
//            // Arrange
//            var value = TestEnum.FirstValue;

//            // Act
//            var result1 = value.Humanize();
//            var result2 = value.Humanize();

//            // Assert
//            Assert.AreEqual(result1, result2);
//            Assert.AreEqual("First Value Description", result1);
//        }
//    }
//}