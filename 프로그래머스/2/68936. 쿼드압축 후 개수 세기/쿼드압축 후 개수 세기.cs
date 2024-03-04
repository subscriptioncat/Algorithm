using System;

public class Solution {
    public int[] solution(int[,] arr) {
        int[] answer = new int[2];
        int[] store = new int[3];
        int[,] oldArr = arr;
        int[,] newArr;
        
        while (oldArr.Length != 1)
        {
            int length = oldArr.GetLength(0) / 2;
            newArr = new int[length, length];
            int maxCount = length * length;
            for (int i = 0 ; i < maxCount; i++)
            {
                int newX = i / length;
                int newY = i % length;
                int x = newX * 2;
                int y = newY * 2;
                if (oldArr[x, y] == oldArr[x, y +1] && oldArr[x, y] == oldArr[x+1, y] && oldArr[x, y] == oldArr[x + 1, y + 1])
                {
                    newArr[newX, newY] = oldArr[x, y];
                }
                else
                {
                    newArr[newX, newY] = 2;
                    store[oldArr[x, y]]++;
                    store[oldArr[x, y + 1]]++;
                    store[oldArr[x + 1, y]]++;
                    store[oldArr[x + 1, y + 1]]++;
                }
            }
            oldArr = newArr;
        }
        answer[0] = store[0];
        answer[1] = store[1];
        if(oldArr[0,0] != 2)
            answer[oldArr[0, 0]]++;
        return answer;
    }
}