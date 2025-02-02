//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumDehumanizeExtensionsTests {
//        private enum TestEnum {
//            FirstValue,
//            SecondValue,
//            ThirdValue,
//            ALLCAPS,
//            MixedCASE
//        }

//        [TestMethod]
//        public void DehumanizeTo_ValidInput_ReturnsCorrectEnum() {
//            // Arrange
//            string[] inputs = {
//                "First Value",
//                "Second Value",
//                "Third Value"
//            };
//            TestEnum[] expected = {
//                TestEnum.FirstValue,
//                TestEnum.SecondValue,
//                TestEnum.ThirdValue
//            };

//            // Act & Assert
//            for (int i = 0; i < inputs.Length; i++) {
//                var result = inputs[i].DehumanizeTo(typeof(TestEnum));
//                Assert.AreEqual(expected[i], result);
//            }
//        }

//        [TestMethod]
//        public void DehumanizeTo_CaseVariations_ReturnsCorrectEnum() {
//            // Arrange & Act & Assert
//            Assert.AreEqual(TestEnum.ALLCAPS, "All Caps".DehumanizeTo(typeof(TestEnum)));
//            Assert.AreEqual(TestEnum.MixedCASE, "Mixed Case".DehumanizeTo(typeof(TestEnum)));
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NoMatchFoundException))]
//        public void DehumanizeTo_InvalidInput_ThrowsException() {
//            // Arrange
//            string input = "Non Existent Value";

//            // Act
//            input.DehumanizeTo(typeof(TestEnum));

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        public void DehumanizeTo_InvalidInput_WithReturnNullBehavior_ReturnsNull() {
//            // Arrange
//            string input = "Non Existent Value";

//            // Act
//            var result = input.DehumanizeTo(typeof(TestEnum), OnNoMatch.ReturnsNull);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentException))]
//        public void DehumanizeTo_NonEnumType_ThrowsArgumentException() {
//            // Arrange
//            string input = "Some String";

//            // Act
//            input.DehumanizeTo(typeof(string));

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void DehumanizeTo_NullInput_ThrowsArgumentNullException() {
//            // Arrange
//            string? input = null;

//            // Act
//            input!.DehumanizeTo(typeof(TestEnum));

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void DehumanizeTo_NullTargetEnum_ThrowsArgumentNullException() {
//            // Arrange
//            string input = "First Value";

//            // Act
//            input.DehumanizeTo(null!);

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        [ExpectedException(typeof(NoMatchFoundException))]
//        public void DehumanizeTo_EmptyString_ThrowsNoMatchFoundException() {
//            // Arrange
//            string input = string.Empty;

//            // Act
//            input.DehumanizeTo(typeof(TestEnum));

//            // Assert is handled by ExpectedException
//        }

//        [TestMethod]
//        public void DehumanizeTo_OriginalEnumString_ReturnsCorrectEnum() {
//            // Arrange & Act & Assert
//            Assert.AreEqual(TestEnum.FirstValue, "FirstValue".DehumanizeTo(typeof(TestEnum)));
//            Assert.AreEqual(TestEnum.ALLCAPS, "ALLCAPS".DehumanizeTo(typeof(TestEnum)));
//        }

//        [TestMethod]
//        public void DehumanizeTo_MultipleSpaces_ReturnsCorrectEnum() {
//            // Arrange & Act & Assert
//            Assert.AreEqual(TestEnum.FirstValue, "First    Value".DehumanizeTo(typeof(TestEnum)));
//            Assert.AreEqual(TestEnum.SecondValue, "Second  Value".DehumanizeTo(typeof(TestEnum)));
//        }
//    }
//}