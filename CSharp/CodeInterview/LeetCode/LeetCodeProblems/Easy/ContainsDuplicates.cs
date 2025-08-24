using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class ContainsDuplicates
    {
        public bool ContainsDuplicatesSolution(int[] nums)
        {
            var numsOrdered = nums.OrderBy(x => x).ToList();
            for (int i = 0; i < numsOrdered.Count - 1; i++)
            {

                if (numsOrdered[i] == numsOrdered[i + 1])
                    return true;
            }
            return false;
        }

        public bool ContainsDuplicateMostOptimized(int[] nums)
        {
            return nums.Distinct().Count() != nums.Count();
        }

        public bool ContainsDuplicateGoodOptimized(int[] nums)
        {
            HashSet<int> numsNotRepeated = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsNotRepeated.Contains(nums[i]))
                {
                    return true;
                }
                numsNotRepeated.Add(nums[i]);
            }
            return false;
        }

        public bool ContainsDuplicateWorstOptimized(int[] nums)
        {
            List<int> numsNotRepeated = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsNotRepeated.Contains(nums[i]))
                {
                    return true;
                }
                numsNotRepeated.Add(nums[i]);
            }
            return false;
        }
    }
}
