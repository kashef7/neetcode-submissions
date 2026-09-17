public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Create A Map to Store numbers and their Index
        var map = new Dictionary<int,int>();
        int[] result = new int[2];
        //Loop Over numbers
        for(int i = 0; i < nums.Length;i++){
            //Calc needed for Target
            int needed = target - nums[i];
            //Check if it exists return -> indexed
            if(map.ContainsKey(needed)){
                result[0] = map[needed];
                result[1] = i;
                break;
            }
            //else add number with index to Map
            map[nums[i]] = i;
        }
        return result;
    }
}
