public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int[] charCounts = new int[26];
        foreach (char c in chars) {
            charCounts[c - 'a']++;
        }
        
        int count = 0;
        foreach (string word in words) {
            int[] wordCharCounts = new int[26]; 
            bool isGood = true;
            foreach (char c in word) {
                if (++wordCharCounts[c - 'a'] > charCounts[c - 'a']) {
                    isGood = false;
                    break;
                }
            }
            if (isGood) {
                count += word.Length;
            }
        }
        return count;
    }
}
