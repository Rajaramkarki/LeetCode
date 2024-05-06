public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int length = nums.Length;

        int[] smallestTillNow = new int[length];
        int[] largestTillNow = new int[length];

        
        smallestTillNow[0] = nums[0];
        largestTillNow[length - 1] = nums[length - 1];

        for(int i = length - 2; i >= 0; i--)
        {
            largestTillNow[i] = Math.Max(largestTillNow[i + 1], nums[i]);
        }

        for(int i = 1; i< length; i++)
        {
            smallestTillNow[i] = Math.Min(smallestTillNow[i - 1], nums[i]);
        }

        for(int i = 0; i< length; i++)
        {
            if(nums[i] != smallestTillNow[i] && nums[i] != largestTillNow[i])
                return true;

        }

        return false;
        
    }
}