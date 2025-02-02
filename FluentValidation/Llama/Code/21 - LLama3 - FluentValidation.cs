//using System;
//using System.Globalization;
//using FluentAssertions;
//using FluentAssertions.Execution;
//using FluentAssertions.Primitives;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Fl

//namespace FluentValidation.Resources.Tests;

//[TestClass]
//public class LanguageManagerTests {
//	[TestMethod]
//	public void GetString_ValidKey_ReturnsTranslation() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");
//		manager.AddTranslation("fr", "key", "Traduction");

//		// Act
//		var result = manager.GetString("key");

//		// Assert
//		result.Should().Be("Translation");
//	}

//	[TestMethod]
//	public void GetString_InvalidKey_ReturnsEmptyString() {
//		// Arrange
//		var manager = new LanguageManager();

//		// Act
//		var result = manager.GetString("key");

//		// Assert
//		result.Should().BeEmpty();
//	}

//	[TestMethod]
//	public void GetString_SpecificCulture_ReturnsTranslation() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");
//		manager.AddTranslation("fr", "key", "Traduction");

//		// Act
//		var result = manager.GetString("key", CultureInfo.CreateSpecificCulture("fr"));

//		// Assert
//		result.Should().Be("Traduction");
//	}

//	[TestMethod]
//	public void GetString_SpecificCulture_WithNoTranslation_ReturnsDefaultCulture() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");

//		// Act
//		var result = manager.GetString("key", CultureInfo.CreateSpecificCulture("fr"));

//		// Assert
//		result.Should().Be("Translation");
//	}

//	[TestMethod]
//	public void GetString_SpecificCulture_WithNoTranslationAndParentCulture_ReturnsDefaultCulture() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");

//		// Act
//		var result = manager.GetString("key", CultureInfo.CreateSpecificCulture("de-DE"));

//		// Assert
//		result.Should().Be("Translation");
//	}

//	[TestMethod]
//	public void GetString_SpecificCulture_WithNoTranslationAndParentCultureAndFallbackCulture_ReturnsFallbackCulture() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");

//		// Act
//		var result = manager.GetString("key", CultureInfo.CreateSpecificCulture("es-ES"));

//		// Assert
//		result.Should().Be("Translation");
//	}

//	[TestMethod]
//	public void GetString_DisabledLocalization_ReturnsTranslationFromDefaultCulture() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");
//		manager.Enabled = false;

//		// Act
//		var result = manager.GetString("key");

//		// Assert
//		result.Should().Be("Translation");
//	}

//	[TestMethod]
//	public void GetString_DisabledLocalization_WithNoTranslation_ReturnsEmptyString() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.Enabled = false;

//		// Act
//		var result = manager.GetString("key");

//		// Assert
//		result.Should().BeEmpty();
//	}

//	[TestMethod]
//	public void GetString_NullCulture_ReturnsTranslationFromDefaultCulture() {
//		// Arrange
//		var manager = new LanguageManager();
//		manager.AddTranslation("en", "key", "Translation");

//		// Act
//		var result = manager.GetString("key", null);

//		// Assert
//		result.Should().Be("Translation");
//	}
//}
