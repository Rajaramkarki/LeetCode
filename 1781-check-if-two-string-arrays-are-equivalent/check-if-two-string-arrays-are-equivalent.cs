public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string firstString = "";
        string secondString = "";

        foreach (string i in word1)
        {
            firstString += i;
        }

        foreach (string i in word2)
        {
            secondString += i;
        }

        if(firstString == secondString)
            return true;
        else
            return false;
    }
}