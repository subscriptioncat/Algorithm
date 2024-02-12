using System;

public class Solution 
{
    public bool[] visitArray;
    public int dungeonsGetLength0;
    public int answer;
    
    public int solution(int k, int[,] dungeons) 
    {
        dungeonsGetLength0 = dungeons.GetLength(0);
        visitArray = new bool[dungeonsGetLength0];
        DFS(k, dungeons, 0);
        return answer;
    }
    
    public void DFS(int k, int[,] dungeons, int count)
    {
        for (int i = 0; i < dungeonsGetLength0; i++)
        {
            if (!visitArray[i] && dungeons[i, 0] <= k)
            {
                visitArray[i] = true;
                DFS(k - dungeons[i, 1], dungeons, count + 1);
                visitArray[i] = false;
            }
        }
        answer = answer < count ? count : answer;
    }
}