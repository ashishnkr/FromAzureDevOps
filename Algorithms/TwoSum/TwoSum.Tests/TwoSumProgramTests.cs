using System;
using TwoSum;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class TwoSumProgramTests
    {
        [TestMethod]
        public void TwoSum_Check1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] expected = { 0, 1 };
            int target = 9;
            var result = TwoSumProgram.TwoSum(nums, target);
            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void TwoSum_Check2()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] expected = { 1, 2 };
            int target = 18;
            var result = TwoSumProgram.TwoSum(nums, target);
            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void TwoSum_Check3()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] expected = { 2, 3 };
            int target = 26;
            var result = TwoSumProgram.TwoSum(nums, target);
            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void TwoSum_Check4()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] expected = { 0, 3 };
            int target = 17;
            var result = TwoSumProgram.TwoSum(nums, target);
            Assert.IsTrue(result.SequenceEqual(expected));
        }
    }
}
