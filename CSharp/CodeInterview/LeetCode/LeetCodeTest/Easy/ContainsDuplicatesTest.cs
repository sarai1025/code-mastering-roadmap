using LeetCodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.Easy
{
    public  class ContainsDuplicatesTest
    {
        [Fact]
        public void Test1()
        {
            ContainsDuplicates containsDuplicates = new ContainsDuplicates();
            int[] nums = [1, 2, 3, 1];

            var result = containsDuplicates.ContainsDuplicateMostOptimized(nums);

            Assert.True(result);
        }
    }
}
