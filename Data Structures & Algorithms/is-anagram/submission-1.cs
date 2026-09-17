// if string length are not equal -> return False
// if it is an anagram then the number of the Occourance of Each letter in each string is equal

public class Solution {
    public bool IsAnagram(string s, string t) {
        //Check if string length not equal -> return False
        if(s.Length != t.Length){
            return false;
        }
        //Create the Maps to store Char No
        var MapS = new Dictionary<char,int>();
        var MapT = new Dictionary<char,int>();
        //Loop over the Two strings
        for(int i = 0; i < s.Length;i++){
            //We Check if the Char is in the Map if yes += 1 else we Add it with Value 1
            if(MapS.ContainsKey(s[i])){
                MapS[s[i]]++;
            } else
            {
                MapS[s[i]] = 1;
            }
            if(MapT.ContainsKey(t[i])){
                MapT[t[i]]++;
            } else
            {
                MapT[t[i]] = 1;
            }
        }
        //We go over the Two Maps and if there is a Char with diffrent Number of Occurance in any one of them we return false
        foreach(var ch in MapS){
            if(!MapT.ContainsKey(ch.Key)){
                return false;
            }
            if(MapT[ch.Key] != MapS[ch.Key]){
                return false;
            }
        }
        //else return -> true
        return true;
    }
}
