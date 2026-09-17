//Two strings are anagram if they both have the same frequency of letters
//We can store the letters in an array of size 26
//if the strings are not the same length -> exit rigth away impossible to be anagram
//We loop through both strings at the same time and count the number of occourance
//We loop through both the arrays and check if on value is not equal to the other we return false
//else return true

public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] arrS = new int[26];
        int[] arrT = new int[26];

        if(s.Length != t.Length){return false;}

        for(int i = 0;i < s.Length;i++){
            arrS[s[i] - 'a']++;
            arrT[t[i] - 'a']++;
        }

        for(int i = 0;i< 26;i++){
            if(arrS[i] != arrT[i]){
                return false;
            }
        }

        return true;
    }
}
