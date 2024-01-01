using System;
using System.Collections;
using System.Text;
public class Solution {
    public int solution(string s) {
        Stack stack = new Stack();
        StringBuilder sb = new StringBuilder();
        int count = 0;
        int sLength = s.Length;
        for (int i  = 0; i < sLength; i++)
        {
            sb.Clear();
            sb.Append(s.Substring(i));
            sb.Append(s.Substring(0, i));
            stack.Clear();
            bool isCountAdd = true;
            for (int j = 0; j < sLength; j++)
            {
                if (sb[j] == 40 || sb[j] == 91 || sb[j] == 123)
                    stack.Push(sb[j]);
                else
                {
                    if(stack.Count == 0)
                    {
                        isCountAdd = false;
                        break;
                    }
                    char c = (char)stack.Peek();
                    if (sb[j] == 41 && c == 40)
                        stack.Pop();
                    else if (c == sb[j] - 2)
                        stack.Pop();
                    else
                    {
                        isCountAdd = false;
                        break;
                    }  
                }
            }
            if( isCountAdd && stack.Count == 0)
                count++;
        }
        return count;
    }
}