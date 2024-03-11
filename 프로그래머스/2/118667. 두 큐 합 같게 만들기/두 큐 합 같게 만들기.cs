using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] queue1, int[] queue2) {
        int answer = 0;
        Queue<int> storage1 = new Queue<int>(queue1);
        Queue<int> storage2 = new Queue<int>(queue2);
        long sum1 = storage1.Sum(x => (long)x);
        long sum2 = storage2.Sum(x => (long)x);
        long half = (sum1 + sum2) / 2;
        int max = queue1.Length * 2 + queue2.Length; 
        int queue1Max = queue1.Max();
        int queue2Max = queue2.Max();
        long test = (sum1 % 2) ^ (sum2 % 2);
        
        if (test == 1 || queue1Max > half || queue2Max > half) 
            return -1;
        for(int i = 0; i < max; i++)
        {
            if (sum1 > sum2)
            {
                int n = storage1.Dequeue();
                storage2.Enqueue(n);
                sum1 -= n;
                sum2 += n;
            }
            else if (sum2 > sum1)
            {
                int n = storage2.Dequeue();
                storage1.Enqueue(n);
                sum1 += n;
                sum2 -= n;
            }
            else
                return i;
        }
        return -1;
    }
}