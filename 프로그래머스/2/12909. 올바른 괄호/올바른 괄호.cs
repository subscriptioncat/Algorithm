using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        int sLength = s.Length;
        Stack<char> stack = new Stack<char>();
        char[] cfChar = new char[2]
        {
            '(',
            ')'
        };


        for (int i = 0; sLength > i; i++)
        {
            if(s[i] == cfChar[0])
            {
                stack.Push(s[i]);
            }
            else
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0 ? true : false;
    }
}