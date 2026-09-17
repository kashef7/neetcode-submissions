public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ans = new int[2];
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0;i< nums.Length;i++){
            int diff = target - nums[i];
            if(map.ContainsKey(diff)){
                ans[0] = Math.Min(map[diff],i);
                ans[1] = Math.Max(map[diff],i);
                return ans;
            }else{
                map.Add(nums[i],i);
            }
        }
        return ans;
    }
}
