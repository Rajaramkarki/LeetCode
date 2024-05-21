public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();

        int n = nums.Length;
        int subsetCount = (int)Math.Pow(2, n); 
        
        for (int i = 0; i < subsetCount; i++) {
            List<int> subset = new List<int>();
            for (int j = 0; j < n; j++) {
                if ((i & (1 << j)) != 0) {
                    subset.Add(nums[j]);
                }
            }
            result.Add(subset);
        }

        return result;
    }
}