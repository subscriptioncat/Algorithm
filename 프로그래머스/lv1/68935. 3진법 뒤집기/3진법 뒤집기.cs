using System;
using System.Collections;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        Stack s = new Stack();
        while (n > 2)
        {
            s.Push(n % 3);
            n /= 3;
        }
        s.Push(n);
        int count = s.Count;
        for(int i = 0; i < count; i++)
            answer += (int)s.Pop() * (int)Math.Pow(3, i);
        return answer;
    }
}