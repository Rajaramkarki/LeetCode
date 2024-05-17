public class Solution {
    public bool MakeEqual(string[] words) {
        Dictionary<char, int> myDict = new Dictionary<char, int>();
        int count = 0;

        for(int i = 0; i < words.Length; i++)
        {
            foreach(char c in words[i])
            {
                if(myDict.ContainsKey(c))
                    myDict[c]++;

                else
                    myDict[c] = 1;   
            }
        }

        foreach(var entry in myDict)
        {
            if(entry.Value % words.Length == 0)
                continue;

            else
                count++;
        }

        if(count > 0)
            return false;

        else
            return true;


    
        // List<int> myList = new List<int>();
        // int sum = 0;

        // for(int i = 0; i< words.Length; i++)
        // {
        //     myList.Add(words[i].Length);
        // }

        // foreach(int i in myList)
        // {
        //     sum += i;
        // }

        // if(sum == 1 && myList.Count == 1)
        //     return true;

        // if(sum % myList.Count == 0 && sum > myList.Count)
        //     return true;

        // else
        //     return false;
    }
}