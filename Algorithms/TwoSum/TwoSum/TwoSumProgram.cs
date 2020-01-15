using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSumProgram
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = { };
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                    result = new int[] { map[complement], i };
                map.Add(nums[i], i);
            }
            return result;
        }
    }
}
