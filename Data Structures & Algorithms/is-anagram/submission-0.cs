public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        int length = s.Length;
        Dictionary<char,int> mapS = new Dictionary<char,int> ();
        Dictionary<char,int> mapT = new Dictionary<char,int> ();

        for(int i = 0;i< length;i++)
        {
          if (!mapS.ContainsKey(s[i]))
          {
            mapS.Add(s[i],1);
          } 
          else
          {
            mapS[s[i]]++;
          }
          if (!mapT.ContainsKey(t[i]))
          {
            mapT.Add(t[i],1);
          }
          else
          {
            mapT[t[i]]++;
          }
        }
      for(int i = 0;i< length; i++)
    {
      if (!mapT.ContainsKey(s[i]) || mapS[s[i]] != mapT[s[i]])
      {
        return false;
      }
    }
    return true;
    }
}
