using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];

        List<int> list = new List<int>();
        for(int i = 0; i < score.Length; i++)
        {
            if( i < k)
            {
                list.Add(score[i]);
                list.Sort((n1, n2) => n2.CompareTo(n1));
            }
            else
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] < score[i])
                    {
                        list.Insert(j, score[i]);
                        break;
                    }
                }
                if(list.Count > k)
                    list.Remove(list.Last());
            }
            answer[i] = list.Last();
        }
        return answer;
    }
}