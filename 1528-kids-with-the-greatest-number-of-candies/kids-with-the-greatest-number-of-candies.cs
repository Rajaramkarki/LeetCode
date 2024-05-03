public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = Enumerable.Repeat(false, candies.Length).ToList();

        int maxCandies = candies.Max();

        for(int i = 0; i < candies.Length; i++)
        {
            candies[i] += extraCandies;

            if(candies[i] >= maxCandies)
                result[i] = true;
        }
        return result;
    }
}