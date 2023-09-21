using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        StringBuilder sb = new StringBuilder();

        int[] intsX = new int[10];
        int[] intsY = new int[10];
        int[] intsXY = new int[10];

        foreach (Char c in X)
            intsX[c - '0']++;
        foreach (Char c in Y)
            intsY[c - '0']++;
        for(int i =0; i < 10; i++)
            intsXY[i] = Math.Min(intsX[i], intsY[i]);
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 0; j < intsXY[i]; j++)
                sb.Append(i);
        }

        if (sb.Length == 0)
            return "-1";

        if (sb[0] == '0')
            return "0";

        return sb.ToString();
    }
}