public class Solution {
    public int MaxScore(string s) {
        int sumOne = 0;
        int sumZero = 0;
        int maxScore = 0;

        for(int i = 0; i < s.Length; i++)
        {   
            if(s[i] == '1')
                sumOne++;
        }

        for(int i = 0; i< s.Length - 1; i++)
        {
            if(s[i] == '0')
                sumZero++;

            else
                sumOne--;

                maxScore = Math.Max(maxScore, sumZero + Math.Abs(sumOne));
        }
        return maxScore;
    }
}