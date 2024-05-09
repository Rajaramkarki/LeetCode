public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) 
    {
        Array.Sort(happiness, (x, y) => y.CompareTo(x));

        long sum = 0;

        for (int i = 0; i < k; i++) 
        {
            if (i == 0 || happiness[i] - i > 0) 
            {
                sum += i == 0 ? happiness[i] : happiness[i] - i;
            }
        }
        return sum;
    }
}