using System;
using System.Linq;

public class Solution {
    public int solution(int n)
    {
        bool[] visit = new bool[n + 1];
        visit[0] = true;
        visit[1] = true;

        int max = (int)Math.Sqrt(n) + 1;
        for(int i = 2; i <= max; i++)
        {
            if(visit[i] == true)
                continue;
            else
            {
                for(int j = i * 2;  j <= n ; j += i)
                {
                    visit[j] = true;
                }
            }
        }
        return visit.Count(b => !b);
    }
}