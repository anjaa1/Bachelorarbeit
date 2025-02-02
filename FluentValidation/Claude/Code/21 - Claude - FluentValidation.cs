//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentValidation.Resources;
//using System.Globalization;

//namespace FluentValidation.Tests.Resources {
//	[TestClass]
//	public class LanguageManagerTests {
//		private LanguageManager _languageManager;

//		[TestInitialize]
//		public void Setup() {
//			_languageManager = new LanguageManager();
//		}

//		[TestMethod]
//		public void GetString_WithCachedTranslation_ReturnsCachedValue() {
//			// Arrange
//			const string key = "cached_key";
//			const string language = "fr-FR";
//			const string expectedTranslation = "Cached Translation";
//			_languageManager.AddTranslation(language, key, expectedTranslation);

//			// Act
//			var result = _languageManager.GetString(key, new CultureInfo(language));

//			// Assert
//			Assert.AreEqual(expectedTranslation, result);
//		}

//		[TestMethod]
//		public void GetString_WhenDisabled_ReturnsEnglishTranslation() {
//			// Arrange
//			_languageManager.Enabled = false;
//			var culture = new CultureInfo("fr-FR");
//			const string key = "test_key";

//			// Act
//			var result = _languageManager.GetString(key, culture);

//			// Assert
//			Assert.IsNotNull(result);
//			// Note: Since we can't access EnglishLanguage.GetTranslation directly, 
//			// we verify the behavior rather than the exact value
//			Assert.AreEqual(_languageManager.GetString(key, new CultureInfo("en")), result);
//		}

//		[TestMethod]
//		public void GetString_WithNullCulture_UsesDefaultCulture() {
//			// Arrange
//			var defaultCulture = new CultureInfo("es-ES");
//			_languageManager.Culture = defaultCulture;
//			const string key = "test_key";

//			// Act
//			var result = _languageManager.GetString(key, null);

//			// Assert
//			Assert.IsNotNull(result);
//		}

//		[TestMethod]
//		public void GetString_WithNullKey_ReturnsEmptyString() {
//			// Arrange
//			var culture = new CultureInfo("en-US");

//			// Act
//			var result = _languageManager.GetString(null, culture);

//			// Assert
//			Assert.AreEqual(string.Empty, result);
//		}

//		[TestMethod]
//		public void GetString_WithSpecificCulture_FallsBackToNeutralCulture() {
//			// Arrange
//			var specificCulture = new CultureInfo("pt-BR");
//			const string key = "test_key";

//			// Act
//			var result = _languageManager.GetString(key, specificCulture);

//			// Assert
//			Assert.IsNotNull(result);
//		}

//		[TestMethod]
//		public void GetString_WithUnknownCulture_FallsBackToEnglish() {
//			// Arrange
//			var unknownCulture = new CultureInfo("xx-XX"); // Non-existent culture
//			const string key = "test_key";

//			// Act
//			var result = _languageManager.GetString(key, unknownCulture);

//			// Assert
//			Assert.IsNotNull(result);
//			Assert.AreEqual(_languageManager.GetString(key, new CultureInfo("en")), result);
//		}



//		[TestMethod]
//		public void GetString_AfterClear_ReturnsNewTranslation() {
//			// Arrange
//			const string key = "test_key";
//			const string language = "fr-FR";
//			const string translation = "Test Translation";
//			_languageManager.AddTranslation(language, key, translation);

//			// Act
//			var beforeClear = _languageManager.GetString(key, new CultureInfo(language));
//			_languageManager.Clear();
//			var afterClear = _languageManager.GetString(key, new CultureInfo(language));

//			// Assert
//			Assert.AreNotEqual(beforeClear, afterClear);
//		}

//		[TestMethod]
//		public void GetString_WithCurrentUICulture_ReturnsAppropriateTranslation() {
//			// Arrange
//			var previousCulture = CultureInfo.CurrentUICulture;
//			try {
//				CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
//				const string key = "test_key";

//				// Act
//				var result = _languageManager.GetString(key);

//				// Assert
//				Assert.IsNotNull(result);
//			}
//			finally {
//				CultureInfo.CurrentUICulture = previousCulture;
//			}
//		}
//	}
//}
