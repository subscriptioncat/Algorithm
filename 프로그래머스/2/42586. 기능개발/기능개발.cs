using System;
using System.Collections;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        Queue queue = new Queue(progresses);
List<int> answerList = new List<int>();
        int day = 0;
        int speedsIndex = 0;
        while (queue.Count > 0)
        {
            day++;
            int answer = 0;
            while (queue.Count != 0 && (int)queue.Peek() + (day * speeds[speedsIndex]) >= 100)
            {
                answer++;
                queue.Dequeue();
                speedsIndex++;
            }
            if(answer > 0)
                answerList.Add(answer);
        } 
        return answerList.ToArray();
    }
}