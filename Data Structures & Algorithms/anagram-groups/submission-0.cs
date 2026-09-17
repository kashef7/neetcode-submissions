public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        List<List<string>> ans = new List<List<string>>(); 
        for(int i = 0;i < strs.Length; i++)
        {
          char [] charArray = strs[i].ToCharArray();
          Array.Sort(charArray);
          string sorted = new string(charArray);
          if (map.ContainsKey(sorted))
          {
            map[sorted].Add(strs[i]);
          } 
          else
          {
            List<string> lst = new List<string>();
            lst.Add(strs[i]);
            map.Add(sorted,lst);
          }
        }
        foreach(List<string> anagram in map.Values)
        {
          ans.Add(anagram);
        }
        return ans;
    }
}
