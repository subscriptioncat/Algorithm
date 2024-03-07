using System;

public class Solution {
    public int[] solution(int n) {
        int max = (n + 1) * n / 2;
        int[] answer = new int[max];
        int index = 0;
        int number = 1;
        int under = 0;
        int underIndex = 0;
        int up = 0;
        while (number <= max)
        {
            for(int i = 0; i < n - under; i++)
            {
                index += i + underIndex;
                answer[index] = number++;
            }

            for(int i = 0;i < n - under -1; i++)
            {
                index++;
                answer[index] = number++;
            }

            for(int i = 0; i < n - under - 2; i++)
            {
                index -= n - i - up;
                answer[index] = number++;
            }

            under += 3;
            up += 1;
            underIndex += 2;
        }
        return answer;
    }
}