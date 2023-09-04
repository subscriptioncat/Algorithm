using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int commandsLength = commands.GetLength(0);
        int[] num;
        int[] answer = new int[commandsLength];
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            num = new ArraySegment<int>(array, commands[i, 0] - 1, commands[i, 1] - commands[i, 0] +1).ToArray();
            Array.Sort(num);
            answer[i] = num[commands[i, 2]-1];
        }
        return answer;
    }
}