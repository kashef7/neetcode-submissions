public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] ans = new int[2];
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0;i< nums.Length;i++){
            int diff = target - nums[i];
            if(map.ContainsKey(diff)){
                int j = map[diff];
                if(i > j){
                    ans[0] = j;
                    ans[1] = i;
                }else{
                    ans[0] = i;
                    ans[1] = j; 
                }
                return ans;
            }else{
                map.Add(nums[i],i);
            }
        }
        return ans;
    }
}
