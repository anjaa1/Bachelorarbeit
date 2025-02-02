//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnglishArticleTests {
//        [TestMethod]
//        public void PrependArticleSuffix_WithTheArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "matrix the" };
//            string[] expected = new[] { "the matrix" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithAnArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "apple an" };
//            string[] expected = new[] { "an apple" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithAArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "book a" };
//            string[] expected = new[] { "a book" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMultipleStrings_HandlesAllCorrectly() {
//            // Arrange
//            string[] input = new[] {
//                "lord of rings the",
//                "hobbit the",
//                "journey an",
//                "story a"
//            };
//            string[] expected = new[] {
//                "the lord of rings",
//                "the hobbit",
//                "an journey",
//                "a story"
//            };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithNoArticles_ReturnsUnchangedStrings() {
//            // Arrange
//            string[] input = new[] { "matrix", "lord", "ring" };
//            string[] expected = new[] { "matrix", "lord", "ring" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithEmptyArray_ReturnsEmptyArray() {
//            // Arrange
//            string[] input = new string[0];

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            Assert.AreEqual(0, result.Length);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithNullString_HandlesNullElements() {
//            // Arrange
//            string[] input = new string[] { null };
//            string[] expected = new string[] { null };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMixedContent_HandlesValidAndInvalidInputs() {
//            // Arrange
//            string[] input = new[] {
//                "matrix the",
//                "",
//                "apple an",
//                null,
//                "book a",
//                "plain"
//            };
//            string[] expected = new[] {
//                "the matrix",
//                "",
//                "an apple",
//                null,
//                "a book",
//                "plain"
//            };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMixedCaseArticles_HandlesCaseInsensitively() {
//            // Arrange
//            string[] input = new[] { "book THE", "apple AN", "car A" };
//            string[] expected = new[] { "THE book", "AN apple", "A car" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}