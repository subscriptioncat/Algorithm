using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int[] tangerine) {
        Dictionary<int, int> tangerineDic = new Dictionary<int, int>();
        List<int> tangerineList = new List<int>();
        int maxValue = 0;
        int count = 0;
        int tangerineLength = tangerine.Length;
        for(int i = 0; i < tangerineLength; i++)
        {
            if (tangerineDic.ContainsKey(tangerine[i]))
                maxValue = ++tangerineDic[tangerine[i]] > maxValue ? tangerineDic[tangerine[i]] : maxValue; 
            else
                tangerineDic.Add(tangerine[i], 1);
        }

        if (k <= maxValue)
            return 1;
        else
        {
            maxValue = 0;
            foreach (int i in tangerineDic.Values)
                tangerineList.Add(i);
            tangerineList = tangerineList.OrderByDescending(n1 => n1).ToList();
            foreach(int i in tangerineList)
            {
                count++;
                maxValue += i;
                if(k <= maxValue)
                    break;
            }
            return count;
        }
    }
}