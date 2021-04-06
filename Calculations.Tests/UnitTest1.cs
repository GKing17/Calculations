using System;
using NUnit.Framework;
using static Calculation.Program;

namespace Calculations.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new int[] { 0, 4, 6, 25, 67, 101, 3 }, ExpectedResult = 67)]
        [TestCase(new int[] { 0, 4, 6, 4, 10, 3 }, ExpectedResult = 6)]
        [TestCase(new int[] { 0, 4, 6, -10, 25, 3, 1, 3 }, ExpectedResult = 6)]
        [TestCase(new int[] { 0, 4, 2, 67, 1, 3 }, ExpectedResult = 4)]
        [TestCase(new int[] { 0, 4, 6, 5, 2, 6, 0, 3 }, ExpectedResult = 5)]
        [TestCase(new int[] { 67, 89, 3 }, ExpectedResult = 67)]
        public int GetMax2nd_original(params int[] inputArray) => FoundMax2nd_Original(inputArray);

        [Test]
        public void FoundMax2nd_Original_WithOneNumber_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => FoundMax2nd_Original(new int[] { 1 }), "Array lenth is equal to zero or too shor for identifiying second large integer.");

        [TestCase(new int[] { int.MinValue, 0 })]
        [TestCase(new int[] { int.MinValue, int.MinValue })]
        [TestCase(new int[] { 0, int.MinValue })]
        [TestCase(new int[] { int.MaxValue, 0 })]
        [TestCase(new int[] { int.MaxValue, int.MaxValue })]
        [TestCase(new int[] { 0, int.MaxValue })]
        public void FoundMax2nd_Original_WithOneOrTwoMinOrMaxIntegers_ThrowArgumentOutOfRangeException(params int[] inputArray) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => FoundMax2nd_Original(inputArray), $"Number cannot be {int.MinValue}.");

        [Test]
        public void FoundMax2nd_Original_WithNulArray_ThrowArgumentNullException() =>
            Assert.Throws<NullReferenceException>(() => FoundMax2nd_Original(null));
    }
}