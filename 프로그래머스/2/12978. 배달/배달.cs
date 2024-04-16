using System;
using System.Collections.Generic;
class Solution
{
    public int newK;
    public int[,] newRoad;
    public Dictionary<int, int> answer;
    public bool[] visitArr;
    public int roadLength;
    public int n;
    
    public int solution(int N, int[,] road, int K)
    {
        newK = K;
        newRoad = road;
        roadLength = road.GetLength(0);
        visitArr = new bool[roadLength];
        answer = new Dictionary<int, int>();
        answer.Add(1,0);

        Algorithm(1,0);    
        return answer.Count;
    }
    
    public void Algorithm(int departure, int count)
    {
        if (count == newK)
            return;
        for(int i = 0; i < roadLength; i++)
        {
            if (!visitArr[i] && (n = count + newRoad[i, 2]) <= newK)
            {
                if (newRoad[i, 0] == departure)
                {
                    visitArr[i] = true;
                    if(answer.ContainsKey(newRoad[i, 1]))
                    {
                        if(answer[newRoad[i, 1]] > n)
                        {
                            answer[newRoad[i, 1]] = n;
                            Algorithm(newRoad[i, 1], n);
                        }
                    }
                    else
                    {
                        answer.Add(newRoad[i, 1], n);
                        Algorithm(newRoad[i, 1], n);
                    }
                }
                else if (newRoad[i, 1] == departure)
                {
                    visitArr[i] = true;
                    if (answer.ContainsKey(newRoad[i, 0]))
                    {
                        if (answer[newRoad[i, 0]] > n)
                        {
                            answer[newRoad[i, 0]] = n;
                            Algorithm(newRoad[i, 0], n);
                        }
                    }
                    else
                    {
                        answer.Add(newRoad[i, 0], n);
                        Algorithm(newRoad[i, 0], n);
                    }
                }
                visitArr[i] = false;
            }
        }
    }
}