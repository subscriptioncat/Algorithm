using System;
using System.Text;
public class Solution {
    public string solution(string number, int k) {
        StringBuilder answer = new StringBuilder();
        int numberLength = number.Length;
        int startIndex = 0;
        int index = 0;
        Console.WriteLine(numberLength);
        while (k != 0 && startIndex + k < numberLength)
        {
            char max = number[startIndex];
            index = startIndex;
            for (int i =  startIndex + 1; i <= startIndex + k; i++)
            {
                if( max < number[i])
                {
                    max = number[i];
                    index = i;
                }
            }
            k -= index - startIndex;
            startIndex = index + 1;
            answer.Append(max);
        }
        if (k == 0)
            answer.Append(number.Substring(startIndex));
        return answer.ToString();
    }
}