using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[,] clothes) {
        Dictionary<string,int> clothesDic = new Dictionary<string,int>();
        int clotesLength = clothes.GetLength(0);
        for(int i = 0; i < clotesLength; i++)
        {
            if (clothesDic.ContainsKey(clothes[i, 1]))
                clothesDic[clothes[i, 1]]++;
            else
                clothesDic.Add(clothes[i, 1], 1);
        }

        int clothesDicCount = clothesDic.Count;
        int answer = 1;
        foreach(KeyValuePair<string, int> pair in clothesDic)
            answer *= pair.Value + 1;
        return answer - 1;
    }
}