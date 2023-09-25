using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int maxIndex = score.Length / m;
        int answer = 0;
        score = score.OrderByDescending(n => n).ToArray();
        for (int i = 1; i <= maxIndex; i++)
        {
            int nowMinNumber = score[i * m - 1];
            if(nowMinNumber == 1)
            {
                answer += 1 * m * (maxIndex - (i - 1));
                break;
            }
            answer += score[i * m - 1] * m;
        }
        return answer;
    }
}