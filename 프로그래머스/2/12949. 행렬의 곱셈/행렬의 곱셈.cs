using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int arr1Length0 = arr1.GetLength(0);
        int arr1Length1 = arr1.GetLength(1);
        int arr2Length1 = arr2.GetLength(1);
        int[,] answer = new int[arr1Length0, arr2Length1];

        for(int i = 0;  i < arr1Length0; i++)
        {
            for(int j = 0; j < arr2Length1; j++)
            {
                int value = 0;
                for (int n = 0; n < arr1Length1; n++)
                    value += arr1[i, n] * arr2[n, j];
                answer[i, j] = value;
            }
        }
        return answer;
    }
}