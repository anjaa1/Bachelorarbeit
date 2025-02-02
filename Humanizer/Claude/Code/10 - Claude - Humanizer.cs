//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Humanizer;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnglishArticleTests {
//        [TestMethod]
//        public void PrependArticleSuffix_WithTheArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "Matrix the" };
//            string[] expected = new[] { "The Matrix" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithAnArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "Apple an" };
//            string[] expected = new[] { "An Apple" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithAArticle_ReturnsPrependedString() {
//            // Arrange
//            string[] input = new[] { "Book a" };
//            string[] expected = new[] { "A Book" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMixedCaseArticles_HandlesCaseInsensitively() {
//            // Arrange
//            string[] input = new[] { "Book THE", "Apple AN", "Car A" };
//            string[] expected = new[] { "The Book", "An Apple", "A Car" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMultipleStrings_HandlesAllCorrectly() {
//            // Arrange
//            string[] input = new[] {
//                "Lord of the Rings the",
//                "Hobbit the",
//                "Incredible Journey an",
//                "Tale of Two Cities a"
//            };
//            string[] expected = new[] {
//                "The Lord of the Rings",
//                "The Hobbit",
//                "An Incredible Journey",
//                "A Tale of Two Cities"
//            };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithNoArticles_ReturnsUnchangedStrings() {
//            // Arrange
//            string[] input = new[] { "Matrix", "Lord", "Ring" };
//            string[] expected = new[] { "Matrix", "Lord", "Ring" };

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
//                "Matrix the",
//                "",
//                "Apple an",
//                null,
//                "Book a",
//                "Plain"
//            };
//            string[] expected = new[] {
//                "The Matrix",
//                "",
//                "An Apple",
//                null,
//                "A Book",
//                "Plain"
//            };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}