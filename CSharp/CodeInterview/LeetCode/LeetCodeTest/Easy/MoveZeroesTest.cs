using LeetCodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest.Easy
{
    public class MoveZeroesTest
    {
        [Fact]
        public void MoveZeroesSuccessfully()
        {
            MoveZeroes moveZeroesExcercise = new MoveZeroes();
            int[] nums = [0, 1, 0, 3, 12];
            moveZeroesExcercise.MoveZeroesSolution(nums);
            var outs = 0;
        }
    }
}
