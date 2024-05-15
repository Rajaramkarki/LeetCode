public class Solution {

    public int MinOperations(string s) {
        int length = s.Length;
        string firstResult = "0";
        string secondResult = "1";

        int count0 = countDifferences(findResult(firstResult, length), s);
        int count1 = countDifferences(findResult(secondResult, length), s);

        return Math.Min(count0, count1);
    }

    static string findResult(string s, int length)
    {
        int i = 0;
        while(i != length - 1)
        {
            if(s[i] == '0'){
                s += '1';
                i++;
            }
            else
            {
                s+= '0';
                i++;
            }
        }

        return s;
    }

    static int countDifferences(string s1, string s2)
    {
        int differences = 0;
        for(int i = 0; i< s1.Length; i++)
        {
            if(s1[i] != s2[i])
            {
                differences++;
            }
        }

        return differences;
    }
}