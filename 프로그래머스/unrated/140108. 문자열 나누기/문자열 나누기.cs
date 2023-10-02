using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string s) {
        int answer = 0;
        int sLenght = s.Length;

        char baseChar = '0';
        int baseInt = 0;
        int nowInt = 0;

        foreach (char c in s)
        {
            if(baseChar == '0')
            {
                baseChar = c;
            }

            if(c == baseChar)
            {
                baseInt++;
            }
            else
            {
                nowInt++;
            }

            if(baseInt == nowInt)
            {
                baseChar = '0';
                baseInt = 0;
                nowInt = 0;
                answer++;
            }
        }
        if(baseInt != 0)
            answer++;
        return answer;
    }
}