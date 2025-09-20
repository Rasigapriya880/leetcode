public class Solution {
    public int DifferenceOfSum(int[] nums) 
    {
        int elementSum = 0;
        int digitSum = 0;
        foreach (int number in nums)
         {
            elementSum += number;
            int temp = number;
            while (temp > 0) 
            {
                digitSum += temp % 10;
                temp /= 10;
            }
        }
        return elementSum - digitSum;
        
    }
}