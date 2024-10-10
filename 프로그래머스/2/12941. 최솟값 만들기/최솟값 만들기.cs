using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] A, int[] B)
    {
        int answer = 0;

        A = A.OrderBy(x => x).ToArray();
        B = B.OrderByDescending(x => x).ToArray();

        for (int i = 0; i < A.Length; i++)
            answer += A[i] * B[i];

        return answer;
    }
}