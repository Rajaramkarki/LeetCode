public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        int[] rightArray = new int[n];
        int[] leftArray = new int[n];
        int[] result = new int[n];

        for(int i = 0; i< n; i++)
        {
            rightArray[i] = 1;
            leftArray[i] = 1;
        }

        for(int i = 1; i< n; i++)
        {
            leftArray[i] = nums[i - 1] * leftArray[i - 1]; 
        }

        for(int i = nums.Length - 2; i>= 0; i--)
        {
            rightArray[i] = nums[i + 1 ] * rightArray[i + 1];
        }

        for(int i = 0; i < n; i++)
        {
            result[i] = rightArray[i] * leftArray[i];
        }

        return result;
    }
}