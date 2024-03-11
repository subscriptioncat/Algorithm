using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public bool[,] visitArr;
    public List<int> answer;
    public string[] newMaps;
    public int row;
    public int column;
    
    public int[] solution(string[] maps) 
    {
        newMaps = maps;
        row = maps.Length;
        column = maps[0].Length;
        visitArr = new bool[row, column];
        answer = new List<int>();
        Play();
        
        if(answer.Count == 0)
            return new int[] {-1};
       
        return answer.OrderBy(x => x).ToArray();
    }

    public void Play()
    {
        for(int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (!visitArr[i, j])
                {
                    if (newMaps[i][j] != 'X')
                        answer.Add(Check(i, j, 0));
                    else
                        visitArr[i, j] = true;
                }
            }
        }
    }

    public int Check(int index1, int index2, int sum)
    {
        sum += newMaps[index1][index2] - '0';
        visitArr[index1, index2] = true;

        if (index1 > 0 && !visitArr[index1 - 1, index2] && newMaps[index1 - 1][index2] != 'X')
            sum = Check(index1 - 1, index2, sum);
        if (index2 > 0 && !visitArr[index1, index2 - 1] && newMaps[index1][index2 - 1] != 'X')
            sum = Check(index1, index2 - 1, sum);
        if (index1 + 1 < row && !visitArr[index1 + 1, index2] && newMaps[index1 + 1][index2] != 'X')
            sum = Check(index1 + 1, index2, sum);
        if (index2 + 1 < column && !visitArr[index1, index2 + 1] && newMaps[index1][index2 + 1] != 'X')
            sum = Check(index1, index2 + 1, sum);

        return sum;
    }   
}