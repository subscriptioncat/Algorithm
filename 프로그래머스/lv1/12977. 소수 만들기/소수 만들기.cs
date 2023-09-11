using System;

class Solution
{
    public int solution(int[] nums)
    {
        int sum = 0;
        int answer = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            for(int y = x+1;  y < nums.Length; y++)
            {
                for(int z = y+1; z < nums.Length; z++)
                {
                    sum = nums[x] + nums[y] + nums[z];
                    for (int n = 2; n <= sum; n++) 
                    {
                        if(sum % n == 0 && sum != n)
                            break;
                        else if(n == sum)
                            answer++;
                    }
                }
            }
        }

        return answer;
    }
}