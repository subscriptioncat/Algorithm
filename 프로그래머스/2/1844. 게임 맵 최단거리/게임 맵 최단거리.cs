using System;
using System.Collections.Generic;

class Solution {
    private int _posX_Max;
    private int _posY_Max;
    private int[,] _direction;

    public int solution(int[,] maps)
    {
        _posX_Max = maps.GetLength(0);
        _posY_Max = maps.GetLength(1);
        _direction = new int[,]{
            {0,1}, //오른쪽
            {0,-1},//왼쪽
            {1,0}, //아래
            {-1,0},//위
        };
        BFS(0,0, maps);
        return maps[_posX_Max - 1, _posY_Max - 1] <= 1 ? -1 : maps[_posX_Max - 1, _posY_Max - 1];
    }


    public void BFS(int start_X, int start_Y , int[,] maps)
    {
        Queue<(int,int)> queue = new Queue<(int,int)> ();
        queue.Enqueue((start_X, start_Y));
        while (queue.Count > 0)
        {
            (int x, int y) = queue.Dequeue();

            if (x == _posX_Max - 1 && y == _posY_Max - 1)
                return;

            for (int i = 0; i < 4; i++)
            {
                int newX = x + _direction[i,0];
                int newY = y + _direction[i,1];

                if(newX < 0 || newY < 0 || newX >= _posX_Max || newY >= _posY_Max )
                    continue;

                if (maps[newX, newY] != 1)
                    continue;

                maps[newX, newY] = maps[x,y] + 1;
                queue.Enqueue((newX, newY));
            }
        }
    }
}