using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int m) {
        int max = Math.Max(n, m);
        int min = Math.Min(n, m);
        int fixedMax = max;
        int fixedMin = min;

        int[] answer = new int[2] { 1, 1 };
        Dictionary<int, int> minArr = new Dictionary<int, int>();
        Dictionary<int, int> maxArr = new Dictionary<int, int>();
        minArr.Add(1, 1);
        maxArr.Add(1, 1);
        if (max % min == 0)
        {
            answer[0] = min;
            answer[1] = max;
        }
        else
        {
            for (int i = 2; i <= fixedMax; i++)
            {
                int minCount = 0;
                int maxCount = 0;
                while (max % i == 0)
                {
                    max /= i;
                    maxCount++;
                }
                while (min % i == 0)
                {
                    min /= i;
                    minCount++;
                }
                if (maxCount > 0) { maxArr.Add(i, maxCount); }
                if (minCount > 0) { minArr.Add(i, minCount); }
            }
            foreach (KeyValuePair<int, int> i in maxArr)
            {
                if (minArr.TryGetValue(i.Key, out n))
                    answer[1] *= (int)Math.Pow(i.Key, Math.Max(n, i.Value));
                else
                    answer[1] *= (int)Math.Pow(i.Key, i.Value);
            }
            foreach (KeyValuePair<int, int> i in minArr)
            {
                if (maxArr.TryGetValue(i.Key, out n))
                    answer[0] *= (int)Math.Pow(i.Key, Math.Min(n, i.Value));
                else
                    answer[1] *= (int)Math.Pow(i.Key, i.Value);
            }
        }
        return answer;
    }
}