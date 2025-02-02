//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Resources;
//using System.Globalization;

//[TestClass]
//public class LanguageManagerTests {
//	private LanguageManager _languageManager;

//	[TestInitialize]
//	public void Setup() {
//		_languageManager = new LanguageManager();
//		_languageManager.AddTranslation("en", "greeting", "Hello");
//		_languageManager.AddTranslation("fr", "greeting", "Bonjour");
//		_languageManager.AddTranslation("es", "greeting", "Hola");
//	}

//	[TestMethod]
//	public void GetString_ReturnsTranslation_ForValidKeyAndCulture() {
//		// Arrange
//		var culture = new CultureInfo("fr");

//		// Act
//		var result = _languageManager.GetString("greeting", culture);

//		// Assert
//		Assert.AreEqual("Bonjour", result);
//	}

//	[TestMethod]
//	public void GetString_ReturnsFallbackTranslation_WhenKeyNotFoundForSpecificCulture() {
//		// Arrange
//		_languageManager.AddTranslation("en", "fallback", "Fallback English");
//		var culture = new CultureInfo("de");

//		// Act
//		var result = _languageManager.GetString("greeting", culture);

//		// Assert
//		Assert.AreEqual("Hello", result); // Fallback to English
//	}

//	[TestMethod]
//	public void GetString_ReturnsEmptyString_WhenKeyDoesNotExist() {
//		// Arrange
//		var culture = new CultureInfo("en");

//		// Act
//		var result = _languageManager.GetString("unknown_key", culture);

//		// Assert
//		Assert.AreEqual(string.Empty, result);
//	}

//	[TestMethod]
//	public void GetString_UsesNeutralCulture_WhenSpecificCultureNotAvailable() {
//		// Arrange
//		var culture = new CultureInfo("fr-CA");

//		// Act
//		var result = _languageManager.GetString("greeting", culture);

//		// Assert
//		Assert.AreEqual("Bonjour", result); // Falls back to "fr"
//	}

//	[TestMethod]
//	public void GetString_DisabledLocalization_ReturnsEnglishTranslation() {
//		// Arrange
//		_languageManager.Enabled = false;
//		var culture = new CultureInfo("fr");

//		// Act
//		var result = _languageManager.GetString("greeting", culture);

//		// Assert
//		Assert.AreEqual("Hello", result); // English translation is used
//	}

//	[TestMethod]
//	public void GetString_UsesDefaultCulture_WhenCultureNotSpecified() {
//		// Arrange
//		_languageManager.Culture = new CultureInfo("es");

//		// Act
//		var result = _languageManager.GetString("greeting");

//		// Assert
//		Assert.AreEqual("Hola", result);
//	}

//	[TestMethod]
//	public void GetString_ReturnsEmptyString_WhenTranslationsAreCleared() {
//		// Arrange
//		_languageManager.Clear();
//		var culture = new CultureInfo("en");

//		// Act
//		var result = _languageManager.GetString("greeting", culture);

//		// Assert
//		Assert.AreEqual(string.Empty, result);
//	}
//}
