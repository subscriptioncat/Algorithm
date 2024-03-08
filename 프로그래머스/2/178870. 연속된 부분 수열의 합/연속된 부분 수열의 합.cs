using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] sequence, int k) {
        int[] answer = new int[2];
        int sum = 0;
        int index = Array.IndexOf(sequence, k);
        int sequenceLength = sequence.Length;
        int min = 1000000001;
        int first = 0;
        Queue<int> queue = new Queue<int>();
        if (index > -1)
        {
            answer[0] = index;
            answer[1] = index;
        }
        else
        {
            for (index = 0; index < sequenceLength; index++)
            {
                queue.Enqueue(sequence[index]);
                sum += sequence[index];
                while (sum > k)
                {
                    sum -= queue.Dequeue();
                    first++;
                }
                if (sum == k && index - first < min)
                {
                    min = index - first;
                    answer[0] = first;
                    answer[1] = index;
                }
            }              
        }
        return answer;
    }
}