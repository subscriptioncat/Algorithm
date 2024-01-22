using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        if (n == 1) { return new int[] { 1 }; }
        long count = right - left + 1;
        int[] answer = new int[count];
        long index = 0;
        for(long i = left; i <= right; i++)
        {
            int a = (int)(i % n) + 1;
            int b = (int)(i / n) + 1;
            answer[index] = a > b ? a : b;
            index++;
        }
        return answer;
    }
}