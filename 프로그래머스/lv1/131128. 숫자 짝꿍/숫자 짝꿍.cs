using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        StringBuilder sb = new StringBuilder();
        int[] ints1 = new int[10];
        int[] ints2 = new int[10];

        foreach (Char c in X)
            ints1[c - '0']++;
        foreach (Char c in Y)
            ints2[c - '0']++;

        for (int i = 9; i >= 0; i--)
        {
            int count = ints1[i] < ints2[i] ? ints1[i] : ints2[i];

            for (int j = 0; j < count; j++)
                sb.Append(i);
        }

        if (sb.Length == 0)
            return "-1";

        if (sb.ToString().ToCharArray().Where<Char>(x => x == '0').Count() == sb.Length)
            return "0";

        return sb.ToString();
    }
}