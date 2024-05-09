public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums, (x,y) => y.CompareTo(x));

        int result = (nums[0] - 1) * (nums[1] - 1);

        return result;
        
    }
}