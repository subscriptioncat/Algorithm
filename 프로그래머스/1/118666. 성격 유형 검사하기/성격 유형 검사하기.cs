using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        List<char[]> category = new List<char[]>();
        category.Add(new char[] { 'R', 'T' });
        category.Add(new char[] { 'C', 'F' });
        category.Add(new char[] { 'J', 'M' });
        category.Add(new char[] { 'A', 'N' });

        List<int[]> mbti = new List<int[]>();
        for(int i = 0; i < 4; i++)
        {
            mbti.Add(new int[] { 0, 0 });
        }
        int choicesLength = choices.Length;

        for(int i = 0; i < choicesLength; i++)
        {
            int quotient = choices[i] / 4;
            int remainder = choices[i] % 4;
            int number = 0;
            switch (quotient)
            {
                case 0:
                    number = 4 - remainder;
                    break;
                case 1:
                    number = remainder;
                    break;
            }

            char checkChar = survey[i][0];
            bool isFirst;
            if ((isFirst = checkChar == category[0][0]) || checkChar == category[0][1])
            {
                if (isFirst)
                    mbti[0][quotient] += number;
                else
                    mbti[0][1 - quotient] += number;
            }
            else if ((isFirst = checkChar == category[1][0]) || checkChar == category[1][1])
            {
                if (isFirst)
                    mbti[1][quotient] += number;
                else
                    mbti[1][1 - quotient] += number;
            }
            else if ((isFirst = checkChar == category[2][0]) || checkChar == category[2][1])
            {
                if (isFirst)
                    mbti[2][quotient] += number;
                else
                    mbti[2][1 - quotient] += number;
            }
            else
            {
                isFirst = checkChar == category[3][0];
                if (isFirst)
                    mbti[3][quotient] += number;
                else
                    mbti[3][1 - quotient] += number;
            }
        }

        for(int i = 0; i < 4; i++)
        {
            int first = mbti[i][0];
            int second = mbti[i][1];
            if (first == second)
            {
                answer += category[i][0];
            }
            else if (first > second)
            {
                answer += category[i][0];
            }
            else
            {
                answer += category[i][1];
            }
        }
        return answer;
    }
}