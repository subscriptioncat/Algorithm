using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    int[] _diffs;
    int[] _times;
    long _limit;
    int _diffsCount;

    public int solution(int[] diffs, int[] times, long limit)
    {
        _diffs = diffs;
        _times = times;
        _limit = limit;
        _diffsCount = diffs.Count();

        int low = 1;
        int high = diffs.Max();

        return BinarySearch(low, high);
    }

    public int BinarySearch(int low, int high)
    {
        if (low > high)
            return low;

        int mid = (low + high) / 2;

        if (CheckingLevelUpAndDown(mid))
        {
            return BinarySearch(low, mid - 1);
        }
        else
        {
            return BinarySearch(mid + 1, high);
        } 
    }

    public bool CheckingLevelUpAndDown(int level)
    {
        long time_curr;
        int time_prev;

        //한 Level를 검사하는 문장
        time_curr = 0;
        time_prev = 0;
        for (int i = 0; i < _diffsCount; i++)
        {
            if (_diffs[i] > level)
            {
                time_curr += (time_prev + _times[i]) * (_diffs[i] - level) + _times[i];
            }
            else
            {
                time_curr += _times[i];
            }
            time_prev = _times[i];
        }

        if(time_curr > _limit)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}