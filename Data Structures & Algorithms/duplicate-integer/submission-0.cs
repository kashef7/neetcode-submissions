public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(map.ContainsKey(i))
            {
                return true;
            }
            map.Add(i,1);
        }
        return false;
    }
}