public class Solution {
    public bool hasDuplicate(int[] nums) {
        var map = new HashSet<int>();
        foreach(int item in nums){
            if(map.Contains(item)){
                return true;
            }
            map.Add(item);
        }
        return false;
    }
}