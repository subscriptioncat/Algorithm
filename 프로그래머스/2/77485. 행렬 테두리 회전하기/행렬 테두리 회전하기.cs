using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int rows, int columns, int[,] queries) {
        int queriesRow = queries.GetLength(0);
        int[] answer = new int[queriesRow];

        int[,] storageArr = new int[rows, columns];

        // 값 채우기
        int index = 1;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                storageArr[i, j] = index++;
            }
        }

        // 조건 확인
        for(int i = 0; i < queriesRow; i++)
        {
            int minColumn = queries[i, 1] - 1;
            int maxColumn = queries[i, 3] - 1;
            int minRow = queries[i, 0] - 1;
            int maxRow = queries[i, 2] - 1;
            int temporaryStorage = storageArr[minRow, maxColumn];
            HashSet<int> hs = new HashSet<int>();

            for (int j = maxColumn; j > minColumn; j--)
            {
                storageArr[minRow, j] = storageArr[minRow, j - 1];
                hs.Add(storageArr[minRow, j]);
            }


            for (int j = minRow; j < maxRow; j++)
            {
                storageArr[j, minColumn] = storageArr[j + 1, minColumn];
                hs.Add(storageArr[j, minColumn]);
            }


            for ( int j = minColumn; j < maxColumn; j++)
            {
                storageArr[maxRow, j] = storageArr[maxRow, j + 1];
                hs.Add(storageArr[maxRow, j]);
            }


            for (int j = maxRow; j > minRow + 1; j--)
            {
                storageArr[j, maxColumn] = storageArr[j - 1, maxColumn];
                hs.Add(storageArr[j, maxColumn]);
            }

            storageArr[minRow + 1, maxColumn] = temporaryStorage;
            hs.Add(temporaryStorage);
            answer[i] = hs.Min<int>();
        }
        return answer;
    }
}