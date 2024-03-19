using System;
using System.Collections.Generic;
public class Solution {
    int answer;
    int[,] newWires;
    bool[] visitArr;
    int newWiresLength;
    int maxNode;
    HashSet<int> nodeHS;
    
    public int solution(int n, int[,] wires) 
    {
        answer = n;
        newWires = wires;
        newWiresLength = newWires.GetLength(0);
        maxNode = n;
        Start();
        return answer;
    }

    public void Start()
    {
        for (int i = 0; i < newWiresLength; i++)
        {
            visitArr = new bool[newWiresLength];
            visitArr[i] = true;
            nodeHS = new HashSet<int>();
            Algorithm(newWires[i, 0]);
            int count = Math.Abs(maxNode - (nodeHS.Count * 2));
            answer = answer > count ? count : answer;
        }
    }

    void Algorithm(int node)
    {
        nodeHS.Add(node);
        for (int i = 0;i < newWiresLength;i++)
        {
            if (!visitArr[i] ) 
            {
                if(newWires[i, 0] == node)
                {
                    visitArr[i] = true;
                    Algorithm(newWires[i, 1]);
                }
                else if(newWires[i, 1] == node)
                {
                    visitArr[i] = true;
                    Algorithm(newWires[i, 0]);
                }
            }
        }
    }
}