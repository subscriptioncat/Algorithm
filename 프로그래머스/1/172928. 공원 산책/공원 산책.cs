using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int parkLenght = park.Length;
        int routesLenght = routes.Length;
        int nowPosX = 0;
        int nowPosY = 0;
        int maxPosX = park[0].Length;
        int maxPosY = park.Length;
        bool isError = false;
        // 시작 위치 찾기
        for (int i = 0; i < parkLenght; i++)
        {
            int num = park[i].IndexOf('S');
            if(num != -1)
            {
                nowPosX = num;
                nowPosY = i;
                break;
            }
        }

        for (int i = 0;i < routesLenght; i++)
        {
            int addNum = routes[i][2]-48;
            int checkNum = 0;
            isError = false;
            switch (routes[i][0]) 
            {
                case 'N':
                    checkNum = nowPosY - addNum;
                    if (checkNum < 0)
                    {
                        isError = true;
                    }
                    else
                    {
                        for (int j = nowPosY - 1; j >= checkNum; j--)
                        {
                            if (park[j][nowPosX] == 'X')
                            {
                                isError = true;
                            }
                        }
                    }
                    nowPosY = !isError ? nowPosY - addNum : nowPosY;
                    break;
                case 'S':
                    checkNum = nowPosY + addNum;
                    if (checkNum >= maxPosY)
                    {
                        isError = true;
                    }
                    else
                    {
                        for (int j = nowPosY + 1; j <= checkNum; j++)
                        {
                            if (park[j][nowPosX] == 'X')
                            {
                                isError = true;
                            }
                        }
                    }
                    nowPosY = !isError ? nowPosY + addNum : nowPosY;
                    break;
                case 'W':
                    checkNum = nowPosX - addNum;
                    if (checkNum < 0)
                    {
                        isError = true;
                    }
                    else
                    {
                        for (int j = nowPosX - 1; j >= checkNum; j--)
                        {
                            if (park[nowPosY][j] == 'X')
                            {
                                isError = true;
                            }
                        }
                    }
                    nowPosX = !isError ? nowPosX - addNum : nowPosX;
                    break;
                case 'E':
                    checkNum = nowPosX + addNum;
                    if (checkNum >= maxPosX)
                    {
                        isError = true;
                    }
                    else
                    {
                        for (int j = nowPosX + 1; j <= checkNum; j++)
                        {
                            if (park[nowPosY][j] == 'X')
                            {
                                isError = true;
                            }
                        }
                    }
                    nowPosX = !isError ? nowPosX + addNum : nowPosX;
                    break;
            }
        }
        return new int[] {nowPosY, nowPosX};
    }
}