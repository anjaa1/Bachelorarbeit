//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;
//using Moq;

//namespace HumanizerTests {
//    [TestClass]
//    public class TruncateExtensionsTests {
//        private Mock<ITruncator> _mockTruncator;

//        [TestInitialize]
//        public void Setup() {
//            _mockTruncator = new Mock<ITruncator>();
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentNullException))]
//        public void Truncate_ShouldThrowArgumentNullException_WhenTruncatorIsNull() {
//            // Arrange
//            string input = "Test String";

//            // Act
//            input.Truncate(5, "...", null);

//            // Assert: Exception is expected
//        }

//        [TestMethod]
//        public void Truncate_ShouldReturnNull_WhenInputIsNull() {
//            // Arrange
//            string? input = null;

//            // Act
//            var result = input.Truncate(5, "...", _mockTruncator.Object);

//            // Assert
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public void Truncate_ShouldCallTruncatorWithCorrectParameters() {
//            // Arrange
//            string input = "Test String";
//            int length = 5;
//            string truncationString = "...";
//            var from = TruncateFrom.Right;
//            string expectedOutput = "Test...";

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, from))
//                          .Returns(expectedOutput);

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object, from);

//            // Assert
//            Assert.AreEqual(expectedOutput, result);
//            _mockTruncator.Verify(t => t.Truncate(input, length, truncationString, from), Times.Once);
//        }

//        [TestMethod]
//        public void Truncate_ShouldHandleDifferentTruncateFromValues() {
//            // Arrange
//            string input = "Test String";
//            int length = 5;
//            string truncationString = "...";

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Left))
//                          .Returns("...ring");
//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Right))
//                          .Returns("Test...");

//            // Act
//            var resultLeft = input.Truncate(length, truncationString, _mockTruncator.Object, TruncateFrom.Left);
//            var resultRight = input.Truncate(length, truncationString, _mockTruncator.Object, TruncateFrom.Right);

//            // Assert
//            Assert.AreEqual("...ring", resultLeft);
//            Assert.AreEqual("Test...", resultRight);
//        }

//        [TestMethod]
//        public void Truncate_ShouldHandleEdgeCases() {
//            // Arrange
//            string input = "Short";
//            int length = 10;
//            string truncationString = "...";
//            string expectedOutput = "Short";

//            _mockTruncator.Setup(t => t.Truncate(input, length, truncationString, TruncateFrom.Right))
//                          .Returns(expectedOutput);

//            // Act
//            var result = input.Truncate(length, truncationString, _mockTruncator.Object);

//            // Assert
//            Assert.AreEqual(expectedOutput, result);
//        }
//    }
//}
