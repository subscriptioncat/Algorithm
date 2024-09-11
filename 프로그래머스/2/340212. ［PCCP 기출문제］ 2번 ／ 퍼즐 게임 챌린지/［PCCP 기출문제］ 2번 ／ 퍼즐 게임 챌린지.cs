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

        return BinarySearch(1, diffs.Max());
    }

    private int BinarySearch(int low, int high)
    {
        if (low > high)
            return low;

        int mid = (low + high) / 2;

        if (CheckingLevelUpAndDown(mid))
            return BinarySearch(low, mid - 1);
        else
            return BinarySearch(mid + 1, high);
    }

    private bool CheckingLevelUpAndDown(int level)
    {
        long time_curr = 0;
        int time_prev = 0;

        for (int i = 0; i < _diffsCount; i++)
        {
            if (_diffs[i] > level)
                time_curr += (time_prev + _times[i]) * (_diffs[i] - level) + _times[i];
            else
                time_curr += _times[i];

            time_prev = _times[i];
        }

        return time_curr > _limit ? false : true;
    }
}