

public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach(int i in nums){
            if(set.Contains(i)){
                return true;
            } else{
                set.Add(i);
            }
        }
        return false;
    }
}