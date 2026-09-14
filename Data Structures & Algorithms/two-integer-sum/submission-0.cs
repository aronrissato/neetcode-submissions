public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> keyvalue = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            var complement = target - nums[i];

            if (keyvalue.ContainsKey(complement))
            {
                return new int[] { keyvalue[complement], i };
            }

            keyvalue[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}