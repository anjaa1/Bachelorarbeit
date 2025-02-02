//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnglishArticleTests {
//        [TestMethod]
//        public void AppendArticlePrefix_ShouldSortCorrectly_WhenArticlesArePresent() {
//            // Arrange
//            string[] input = { "The Apple", "An Orange", "A Banana" };
//            string[] expected = { "Apple The", "Banana A", "Orange An" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_ShouldSortCorrectly_WhenNoArticlesArePresent() {
//            // Arrange
//            string[] input = { "Apple", "Orange", "Banana" };
//            string[] expected = { "Apple", "Banana", "Orange" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void AppendArticlePrefix_ShouldThrowException_WhenInputIsEmpty() {
//            // Arrange
//            string[] input = { };

//            // Act
//            EnglishArticle.AppendArticlePrefix(input);

//            // Assert: Exception is expected
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_ShouldHandleMixedCaseArticlesCorrectly() {
//            // Arrange
//            string[] input = { "the Apple", "An Orange", "a Banana" };
//            string[] expected = { "Apple the", "Banana a", "Orange An" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_ShouldIgnoreWhitespaceInInput() {
//            // Arrange
//            string[] input = { "  The Apple  ", "   A Banana", "An Orange   " };
//            string[] expected = { "Apple The", "Banana A", "Orange An" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_ShouldReturnInput_WhenArticlesAreNotAtTheStart() {
//            // Arrange
//            string[] input = { "Apple The", "Banana A", "Orange An" };
//            string[] expected = { "Apple The", "Banana A", "Orange An" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void AppendArticlePrefix_ShouldHandleSingleWordInputsCorrectly() {
//            // Arrange
//            string[] input = { "Apple", "Banana", "Orange" };
//            string[] expected = { "Apple", "Banana", "Orange" };

//            // Act
//            var result = EnglishArticle.AppendArticlePrefix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}
