//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumDehumanizeExtensionsTests {
//        private enum TestEnum {
//            FirstCase,
//            SecondCase,
//            ThisIsATest,
//            HTML,
//            XMLDocument
//        }

//        [TestMethod]
//        public void DehumanizeTo_BasicConversion_ReturnsCorrectEnum() {
//            // Arrange
//            var input = "First Case";

//            // Act
//            var result = input.DehumanizeTo(typeof(TestEnum));

//            // Assert
//            Assert.AreEqual(TestEnum.FirstCase, result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_MultipleWords_ReturnsCorrectEnum() {
//            // Arrange
//            var input = "This Is A Test";

//            // Act
//            var result = input.DehumanizeTo(typeof(TestEnum));

//            // Assert
//            Assert.AreEqual(TestEnum.ThisIsATest, result);
//        }

//        [TestMethod]
//        public void DehumanizeTo_Acronyms_ReturnsCorrectEnum() {
//            // Arrange & Act & Assert
//            Assert.AreEqual(TestEnum.HTML, "HTML".DehumanizeTo(typeof(TestEnum)));
//            Assert.AreEqual(TestEnum.XMLDocument, "XML Document".DehumanizeTo(typeof(TestEnum)));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NoMatchFoundException))]
//        public void DehumanizeTo_InvalidInput_ThrowsException() {
//            // Arrange
//            var input = "Non Existent Value";

//            // Act
//            input.DehumanizeTo(typeof(TestEnum));
//        }

//        [TestMethod]
//        public void DehumanizeTo_InvalidInput_WithReturnNullBehavior_ReturnsNull() {
//            // Arrange
//            var input = "Non Existent Value";

//            // Act
//            var result = input.DehumanizeTo(typeof(TestEnum), OnNoMatch.ReturnsNull);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void DehumanizeTo_NonEnumType_ThrowsArgumentException() {
//            // Arrange
//            var input = "Some String";

//            // Act
//            input.DehumanizeTo(typeof(string));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void DehumanizeTo_NullInput_ThrowsArgumentNullException() {
//            // Act
//            string? input = null;
//            input!.DehumanizeTo(typeof(TestEnum));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void DehumanizeTo_NullTargetEnum_ThrowsArgumentNullException() {
//            // Act
//            "First Case".DehumanizeTo(null!);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NoMatchFoundException))]
//        public void DehumanizeTo_EmptyString_ThrowsNoMatchFoundException() {
//            // Act
//            string.Empty.DehumanizeTo(typeof(TestEnum));
//        }
//    }
//}