public class Solution {
    public int FindMaxK(int[] nums) {
        List<int> availableNums = new List<int>();

        double midValue = nums.Length/2;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = nums.Length - 1 ; j > 0; j--)
            {
                if(nums[i] + nums[j] == 0)
                    availableNums.Add(Math.Abs(nums[i]));
            }
        }   

        availableNums.Sort();

        if(availableNums.Count == 0)
            return -1;

        else
            return availableNums[availableNums.Count - 1];
    }
}