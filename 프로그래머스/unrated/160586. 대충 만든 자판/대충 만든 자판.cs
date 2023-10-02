using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int targetsLength = targets.Length;
        int keymapLength = keymap.Length;
        int[] answer = new int[targetsLength];
        int minIndex = 999;

        for (int i = 0; i < targetsLength; i++)
        {
            int nowTargetLenght = targets[i].Length;
            for (int j = 0; j < nowTargetLenght; j++)
            {
                char nowChar = targets[i][j];
                for(int x  = 0; x < keymapLength; x++)
                {
                    int nowIndex = keymap[x].IndexOf(nowChar);
                    if (nowIndex >= 0)
                    {
                        minIndex = minIndex < nowIndex ? minIndex : nowIndex;
                    }
                }
                if(minIndex == 999)
                {
                    answer[i] = -1;
                    break;
                }
                else
                {
                    answer[i] += minIndex + 1;
                }

                minIndex = 999;
            }
        }
        return answer;
    }
}