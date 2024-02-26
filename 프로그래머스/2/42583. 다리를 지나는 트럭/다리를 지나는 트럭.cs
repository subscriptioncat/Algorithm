using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int answer = 0;
        List<int> countList = new List<int>();
        Queue<int> queue = new Queue<int>();
        int truck_weights_Length = truck_weights.Length;
        int index = 0;

        while (index != truck_weights_Length)
        {
            int count = countList.Count();
            for (int j = 0; j < count; j++)
            {
                countList[j]++;
                if (j == 0 && countList[j] == bridge_length)
                {
                    countList.RemoveAt(0);
                    queue.Dequeue();
                    count--;
                    j--;
                }
            }

            if (queue.Sum() + truck_weights[index] <= weight && queue.Count() < bridge_length)
            {
                queue.Enqueue(truck_weights[index]);
                countList.Add(0);
                index++;
            }
            answer++;
        }
        int n = countList.Count;
        if (n > 0)
            answer += bridge_length - countList[n - 1];
        return answer;
    }
}