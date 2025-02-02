//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;
//using System;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumDehumanizeExtensionsTests {
//        [TestMethod]
//        public void DehumanizeTo_TypicalCase_ValidInput_ReturnsEnumValue() {
//            // Arrange
//            var input = "ValidValue";
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ThrowsException;

//            // Act
//            var result = input.DehumanizeTo(targetEnum, onNoMatch);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOfType(result, typeof(EnumTest));
//            Assert.AreEqual(EnumTest.ValidValue, result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_TypicalCase_ValidInput_ReturnsEnumValue_OnNoMatchReturnsNull() {
//            // Arrange
//            var input = "ValidValue";
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ReturnsNull;

//            // Act
//            var result = input.DehumanizeTo(targetEnum, onNoMatch);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_NoMatchFound_ThrowsException_WhenOnNoMatchIsThrowsException() {
//            // Arrange
//            var input = "InvalidValue";
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ThrowsException;

//            // Act and Assert
//            Assert.ThrowsException<NoMatchFoundException>(() => input.DehumanizeTo(targetEnum, onNoMatch));
//        }

//        [TestMethod]
//        public void DehumanizeTo_NoMatchFound_ReturnsNull_WhenOnNoMatchIsReturnsNull() {
//            // Arrange
//            var input = "InvalidValue";
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ReturnsNull;

//            // Act
//            var result = input.DehumanizeTo(targetEnum, onNoMatch);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_InvalidInput_ThrowsArgumentException() {
//            // Arrange
//            var input = "InvalidValue";
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ThrowsException;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentException>(() => input.DehumanizeTo(targetEnum, onNoMatch));
//        }

//        [TestMethod]
//        public void DehumanizeTo_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            var input = null;
//            var targetEnum = typeof(EnumTest);
//            var onNoMatch = OnNoMatch.ThrowsException;

//            // Act and Assert
//            Assert.ThrowsException<ArgumentNullException>(() => input.DehumanizeTo(targetEnum, onNoMatch));
//        }
//    }

//    public enum EnumTest {
//        ValidValue
//    }
//}