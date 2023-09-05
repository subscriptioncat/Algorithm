using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        List<char> chars = new List<char>();
        int[] answer = new int[s.Length];
        chars.Add(s[0]);
        answer[0] = -1;
        for (int i = 1; i < s.Length; i++)
        {
            int n = chars.LastIndexOf(s[i]);
            chars.Add(s[i]);
            if (n == -1)
                answer[i] = -1;
            else
                answer[i] = i - n;
        }
        return answer;
    }
}