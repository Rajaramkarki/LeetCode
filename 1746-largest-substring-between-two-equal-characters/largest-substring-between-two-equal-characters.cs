public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        Dictionary<char, int> myDict = new Dictionary<char, int>();
        int maxLength = -1;

        for(int i = 0; i< s.Length; i++)
        {
            if(myDict.ContainsKey(s[i]))
            {
                int length = i - myDict[s[i]] - 1;

                if(length > maxLength)
                    maxLength = length;
            }
                
            else
                myDict.Add(s[i], i);
        }

        return maxLength;
    }
}