public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        
        for(int i = 0;i < strs.Length; i++)
        {
          char [] charArray = strs[i].ToCharArray();
          Array.Sort(charArray);
          string sorted = new string(charArray);
          if (!map.ContainsKey(sorted))
          {
            map[sorted]= new List<string>();
          }
          map[sorted].Add(strs[i]);
        }
        return new List<List<string>>(map.Values); 
    }
}
