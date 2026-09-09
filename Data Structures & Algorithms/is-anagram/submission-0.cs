public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        if(s.Length != t.Length)
            return false;

        foreach(char c in s)
            charCount[c] = charCount.TryGetValue(c, out int count) ? count + 1 : 1;

        foreach(char c in t)
        {
            if(!charCount.TryGetValue(c, out int count) || count == 0)
                return false;

            charCount[c] = count - 1;
        }

        return true;
    }
}
