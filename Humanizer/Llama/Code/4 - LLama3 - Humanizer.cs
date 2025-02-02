//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Humanizer.Tests {
//    [TestClass]
//    public class EnumHumanizeExtensionsTests {
//        [TestMethod]
//        public void Test_Humanize_Typical_Case() {
//            // Arrange
//            var enumMember = DayOfWeek.Sunday;

//            // Act
//            var result = enumMember.Humanize();

//            // Assert
//            Assert.AreEqual("Sunday", result);
//        }

//        [TestMethod]
//        public void Test_Humanize_Edge_Case_Flag() {
//            // Arrange
//            var enumMember = Color.Red | Color.Green;

//            // Act
//            var result = enumMember.Humanize();

//            // Assert
//            Assert.AreEqual("Red, Green", result);
//        }

//        [TestMethod]
//        public void Test_Humanize_Edge_Case_Flag_Multiple() {
//            // Arrange
//            var enumMember = Color.Red | Color.Green | Color.Blue;

//            // Act
//            var result = enumMember.Humanize();

//            // Assert
//            Assert.AreEqual("Red, Green, Blue", result);
//        }

//        [TestMethod]
//        public void Test_Humanize_Invalid_Input() {
//            // Arrange
//            var invalidEnumMember = 10;

//            // Act and Assert
//            Assert.ThrowsException<InvalidCastException>(() => invalidEnumMember.Humanize());
//        }

//        [TestMethod]
//        public void Test_Humanize_Null_Input() {
//            // Arrange
//            var nullEnumMember = (DayOfWeek?)null;

//            // Act and Assert
//            Assert.ThrowsException<NullReferenceException>(() => nullEnumMember.Humanize());
//        }

//        [TestMethod]
//        public void Test_Humanize_Null_Flag() {
//            // Arrange
//            var nullEnumMember = (Color?)null;

//            // Act and Assert
//            Assert.ThrowsException<NullReferenceException>(() => nullEnumMember.Humanize());
//        }
//    }

//    public class Color {
//        public static Color Red = 1;
//        public static Color Green = 2;
//        public static Color Blue = 4;
//    }

//    public class DayOfWeek {
//        public static DayOfWeek Sunday = 0;
//        public static DayOfWeek Monday = 1;
//        public static DayOfWeek Tuesday = 2;
//    }
//}