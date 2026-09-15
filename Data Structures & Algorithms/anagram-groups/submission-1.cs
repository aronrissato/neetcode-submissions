public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> groups = new(StringComparer.OrdinalIgnoreCase);

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (groups.ContainsKey(key))
                groups[key].Add(str);
            else
                groups[key] = new List<string>() { str };
        }

        return groups.Values.ToList();
    }
}