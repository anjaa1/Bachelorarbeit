//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Humanizer;

//namespace Humanizer.Tests
//{
//    [TestClass]
//    public class EnglishArticleTests
//    {
//        [TestMethod]
//        public void PrependArticleSuffix_WithValidInput_ReturnsCorrectResult()
//        {
//            // Arrange
//            string[] input = { "Dog the", "Apple an", "Book a" };
//            string[] expected = { "The Dog", "An Apple", "A Book" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithNoArticleSuffix_ReturnsUnchanged()
//        {
//            // Arrange
//            string[] input = { "Cat", "Orange", "Notebook" };
//            string[] expected = { "Cat", "Orange", "Notebook" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithMixedCaseArticleSuffix_ReturnsCorrectResult()
//        {
//            // Arrange
//            string[] input = { "Dog The", "Apple An", "Book A" };
//            string[] expected = { "The Dog", "An Apple", "A Book" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithEmptyArray_ReturnsEmptyArray()
//        {
//            // Arrange
//            string[] input = Array.Empty<string>();
//            string[] expected = Array.Empty<string>();

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithNullInput_ThrowsArgumentNullException()
//        {
//            // Arrange
//            string[] input = null!;

//            // Act & Assert
//            Assert.ThrowsException<ArgumentNullException>(() => EnglishArticle.PrependArticleSuffix(input));
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithEmptyStrings_ReturnsEmptyStrings()
//        {
//            // Arrange
//            string[] input = { "", "", "" };
//            string[] expected = { "", "", "" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithSpecialCharacters_ReturnsCorrectResult()
//        {
//            // Arrange
//            string[] input = { "@the", "#an", "&a" };
//            string[] expected = { "@the", "#an", "&a" };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        public void PrependArticleSuffix_WithWhitespaceOnly_ReturnsWhitespaceOnly()
//        {
//            // Arrange
//            string[] input = { " ", "  ", "   " };
//            string[] expected = { " ", "  ", "   " };

//            // Act
//            string[] result = EnglishArticle.PrependArticleSuffix(input);

//            // Assert
//            CollectionAssert.AreEqual(expected, result);
//        }
//    }
//}
