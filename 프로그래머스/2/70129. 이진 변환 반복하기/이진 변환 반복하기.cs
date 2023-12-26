using System;

public class Solution {
    public int[] solution(string s) {
        int count = 0;
        int RemoveCount = 0;
        int nowLength;
        while(s.Length != 1)
        {
            int beforeLength = s.Length;
            nowLength = s.Replace("0", "").Length;
            RemoveCount += beforeLength - nowLength;
            s = Convert.ToString(nowLength, 2);
            count++;
        }
        return new int[2] { count, RemoveCount };
    }
}