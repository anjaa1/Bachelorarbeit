//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace MathNet.Numerics.Tests
//{
//    [TestClass]
//    public class CombinatoricsTests
//    {
//        [TestMethod]
//        public void CombinationsWithRepetition_ValidInputs_ReturnsCorrectResult()
//        {
//            // Test case: n = 5, k = 3
//            int n = 5;
//            int k = 3;
//            double expected = 35; // Calculated as (n+k-1)! / (k! * (n-1)!)
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.AreEqual(expected, result, "The method did not return the expected value for valid inputs.");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_ZeroElements_ReturnsOne()
//        {
//            // Test case: n = 0, k = 0
//            int n = 0;
//            int k = 0;
//            double expected = 1; // Edge case where both n and k are zero
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.AreEqual(expected, result, "The method did not return 1 for n = 0 and k = 0.");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_NegativeInputs_ReturnsZero()
//        {
//            // Test case: n = -1, k = 3
//            int n = -1;
//            int k = 3;
//            double expected = 0; // Invalid input where n is negative
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.AreEqual(expected, result, "The method did not return 0 for negative inputs.");

//            // Test case: n = 3, k = -1
//            n = 3;
//            k = -1;
//            expected = 0; // Invalid input where k is negative
//            result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.AreEqual(expected, result, "The method did not return 0 for negative inputs.");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_ZeroSetElements_ReturnsZero()
//        {
//            // Test case: n = 0, k = 1
//            int n = 0;
//            int k = 1;
//            double expected = 0; // Invalid input where n = 0 but k > 0
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.AreEqual(expected, result, "The method did not return 0 for n = 0 and k > 0.");
//        }

//        [TestMethod]
//        public void CombinationsWithRepetition_LargeValues_NoOverflow()
//        {
//            // Test case: Large inputs to ensure no overflow or errors
//            int n = 50;
//            int k = 20;
//            double result = Combinatorics.CombinationsWithRepetition(n, k);

//            Assert.IsTrue(result > 0, "The method returned an invalid value for large inputs.");
//        }
//    }
//}
