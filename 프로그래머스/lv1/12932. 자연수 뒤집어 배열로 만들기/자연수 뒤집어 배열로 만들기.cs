using System;
public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[(int)Math.Log10(n) + 1];
        int i = 0;
        while (n != 0)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
            i++;
        }
        return answer;
    }
}