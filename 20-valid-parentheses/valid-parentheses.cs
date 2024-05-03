public class Solution {
    public bool IsValid(string s) {
        Stack<char> myStack = new Stack<char>();

        List<char> openingBrackets = new List<char> {'(', '{', '['};
        Dictionary<char, char> myDict = new Dictionary<char, char>
        {
            {'[', ']'},
            {'{','}'},
            {'(',')'}
        };

        for(int i = 0; i < s.Length; i++)
        {
            if(openingBrackets.Contains(s[i]))
                myStack.Push(s[i]);

            else if(myDict.ContainsValue(s[i]))
            {
                if(myStack.Count == 0 || myDict[myStack.Pop()] != s[i])
                    return false;
            }
        }

        if(myStack.Count == 0)
            return true;

        else
            return false;
    }
}