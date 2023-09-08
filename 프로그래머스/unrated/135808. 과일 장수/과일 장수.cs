using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> list = score.ToList();
        list.Sort((n1, n2) => n2.CompareTo(n1));
        for(int i = m;  i <=  list.Count; i = i + m)
        {
            answer += m * list[i - 1];
        }
        return answer;
    }
}