public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int l = score.Length;
        string[] result = new string[l];

        Dictionary<int, int> myDict = new Dictionary<int, int>();

        for(int i = 0; i < l; i++)
        {
            myDict.Add(score[i], i);
        }

        Array.Sort(score,(x,y) => y.CompareTo(x));
        
        for(int i = 0; i< l; i++)
        {
            if(i == 0)
                result[myDict[score[i]]] = "Gold Medal";

            else if(i == 1)
                result[myDict[score[i]]] = "Silver Medal";

            else if(i == 2)
                result[myDict[score[i]]] = "Bronze Medal";

            else
                result[myDict[score[i]]] = (i+1).ToString();
        }

        return result;

    }
}