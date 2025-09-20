public class Solution {
    public int SubtractProductAndSum(int n) 
    {
    int pro = 1;
    int sum = 0;

    for (; n > 0; n /= 10) {
      pro *= n % 10;
      sum += n % 10;
    }

    return pro - sum;
        
    }
}