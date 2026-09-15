public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> groups = [];

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (!groups.ContainsKey(key))
                groups[key] = [];

            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }
}