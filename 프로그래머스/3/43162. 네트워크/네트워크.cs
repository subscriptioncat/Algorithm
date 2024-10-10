using System;
using System.Collections.Generic;

public class Solution {
    bool[,] _visit;
    int _computerCount;
    int[,] _computers;
    public int solution(int n, int[,] computers)
    {
        int answer = n;
        _visit = new bool[computers.GetLength(0), computers.GetLength(1)];
        _computers = computers;
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                if (_visit[i,j])
                    continue;

                if(computers[i,j] == 1)
                {
                    stack.Push(j);
                    _visit[i, j] = true;
                    _visit[j, i] = true;
                }  
            }
            if (stack.Count > 0)
                answer -= DFS(i, stack, n);
        }

        return answer;
    }

    private int DFS(int index, Stack<int> stack, int max)
    {
        HashSet<int> hashset = new HashSet<int>(stack);

        while (stack.Count > 0)
        {
            int n = stack.Pop();
            hashset.Add(n);
            for (int i = index + 1; i < max; i++)
            {
                if(i == n)
                    continue;

                if (_computers[n, i] == 1 && !_visit[n, i])
                {
                    stack.Push(i);
                    _visit[n, i] = true;
                    _visit[i, n] = true;
                }
            }

        }

        return hashset.Count;
    }
}