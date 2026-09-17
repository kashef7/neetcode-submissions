//Focus on the Frequncy of Chars
//Inital Sol
//1st Make A helper function to Check If Two Strings Are Anagram
//2nd We Create the Result list and Add first string in main list into its own Sub list
//3rd We check for each String in strs with Each Sub list in Result if anagram we add to the sublist if not we make new sublist
//4th return Result
//Problems -> O(N^2 * M) 
//HashMap O(1)
// Calc The sum of Char number + freq
// 1 + 1 + 2 + 1 + 3 + 1 = 9 , 2 + 1 + 1 + 1 + 3 + 1 = 9 / aaa 1 + 1 + 1 + 3 = 6 f 5 + 1 = 6
// Key , Index
//New Better Sol
//First Calc Unique Key
//Second Check if Key Exist we add String to the Correct Index else we Add the Key to the HashMap and update the Index by 1
//Insted of Storing the Key as the Ascii Sum we Store it as the Sorted String itself

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();
        var map = new Dictionary<string,int>();
        int index = 0;
        for(int i = 0 ; i < strs.Length;i++){
            string sortedStr = new string(strs[i].OrderBy(a => a).ToArray());
            if(map.ContainsKey(sortedStr)){
                result[map[sortedStr]].Add(strs[i]);
                continue;
            }else
            {
                map[sortedStr] = index;
                result.Add(new List<string>());
                result[index].Add(strs[i]);
                index++;
            }
        }
        return result;
    }
}
