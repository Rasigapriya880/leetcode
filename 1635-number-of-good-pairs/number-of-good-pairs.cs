public class Solution 
{
    public int NumIdenticalPairs(int[] nums)
    {
        int count=0;
        int n=nums.Length;
        for(int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                if(nums[i]==nums[j])
                {
                count++;
                }
            }
            
        }
        return count;
    }
}