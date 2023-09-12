using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int sectionLength = section.Length;
        int i = 0;
        for (int index = 0; index < sectionLength; index++)
        {
            if (i < section[index])
            {
                i = (section[index] + m) - 1;
                answer++;
            }
        }
        return answer;
    }
}