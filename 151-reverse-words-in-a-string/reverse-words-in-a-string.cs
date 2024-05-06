public class Solution {
    public string ReverseWords(string s) {
        List<string> words = new List<string>();
        string currWord = "";
        string result = "";

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == ' ') {
                if (!string.IsNullOrWhiteSpace(currWord)) {
                    words.Add(currWord);
                }
                currWord = "";
            } else {
                currWord += s[i];
            }

            if (i == s.Length - 1 && !string.IsNullOrWhiteSpace(currWord)) {
                words.Add(currWord);
            }
        }

        for(int i = words.Count - 1; i>=0; i--)
        {
            result += words[i] + " ";
        }

        return result.Trim();
    }
}