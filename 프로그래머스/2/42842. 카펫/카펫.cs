using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int sum = brown + yellow;
        int i = 1;
        while (i <= sum)
        {
            if (yellow % i == 0)
                if ((i + 1) * 2 + ((yellow / i) + 1) * 2 == brown)
                    break;
            i++;
        }
        return new int[2] {(yellow / i) + 2, i + 2};
    }
}