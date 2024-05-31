public class Solution {
    public bool CanJump(int[] nums) {
        int maxGoal = nums.Length - 1;

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            int jumpDistance = nums[i] + i;

            if(jumpDistance >= maxGoal)
                maxGoal = i;
        }

        if(maxGoal == 0)
            return true;

        else
            return false;
    }
}