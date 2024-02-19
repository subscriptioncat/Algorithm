using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        int numbersLength = numbers.Length;
        int[] answer = new int[numbersLength];
        Stack<int> stack = new Stack<int>();
        stack.Push(numbers[numbersLength - 1]);
        answer[numbersLength - 1] = -1;
        for (int i = numbersLength -2; i >= 0; i--)
        {
            int n = numbers[i];
            answer[i] = -1;
            while (stack.Count != 0)
            {
                int x = stack.Peek();
                if(x > n)
                {
                    answer[i] = x;
                    break;
                }
                else
                    stack.Pop();
            }
            stack.Push(n);
        }
        return answer;
    }
}