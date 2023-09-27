using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int answerLenght = answers.Length;
        int[] A = { 1, 2, 3, 4, 5 };//5
        int[] B = { 2, 1, 2, 3, 2, 4, 2, 5 }; //8
        int[] C = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }; //10
        int[] count = new int[3];
        List<int> list = new List<int>();

        for( int i = 0; i < answerLenght; i++)
        {
            if(answers[i] == A[i % 5])
            {
                count[0]++;
            }
            if (answers[i] == B[i % 8])
            {
                count[1]++;
            }
            if (answers[i] == C[i % 10])
            {
                count[2]++;
            }
        }
        int max = count.Max();
        int countLenght = count.Length;
        for(int i = 0;i < countLenght; i++)
        {
            if(max == count[i])
            {
                list.Add(i+1);
            }
        }
        return list.ToArray();
    }
}