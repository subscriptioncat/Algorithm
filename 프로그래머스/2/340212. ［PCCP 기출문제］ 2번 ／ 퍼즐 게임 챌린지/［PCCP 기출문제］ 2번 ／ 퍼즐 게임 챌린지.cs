using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int level = 0;
        int diffsCount = diffs.Count();
        long time = long.MaxValue;
        int time_prev = 0;

        while(limit < time)
        {
            level++;
            time = 0;
            time_prev = 0;
            for (int i = 0; i < diffsCount; i++)
            {
                if (diffs[i] > level)
                {
                    time += (time_prev + times[i]) * (diffs[i] - level) + times[i];
                }
                else
                {
                    time += times[i];
                }
                time_prev = times[i];
            }
        }
        return level;
    }
}