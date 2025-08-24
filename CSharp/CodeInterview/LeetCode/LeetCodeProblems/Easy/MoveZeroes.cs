using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class MoveZeroes
    {
        public void MoveZeroesSolution(int[] nums)
        {
            var numberOfZeroes = nums.Count(n => n == 0);
            var numsCopy = nums.Where(n => n != 0).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= numsCopy.Length)
                {
                    nums[i] = 0;
                }
                else
                {
                    nums[i] = numsCopy[i];
                }
            }
        }
    }
}
