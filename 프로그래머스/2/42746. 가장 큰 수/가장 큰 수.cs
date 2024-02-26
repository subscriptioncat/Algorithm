using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
public class Solution {
    public string solution(int[] numbers) {
        if (numbers.Max() == 0)
            return "0";
        StringBuilder answer = new StringBuilder();
        var container = numbers.OrderByDescending(x =>
        {
            if(x == 0)
                return 0;

            double n = Math.Pow(10, (int)Math.Log10(x));
            double number = 0;
            if(n == 1)
                number = x * 0.1 + x * 0.01 + x * 0.001;
            else
                number = Math.Floor( x / n / 10 * 10000) / 10000;
            return (x + number) / n;
        });
        foreach (var item in container)
            answer.Append(item);
        return answer.ToString();
    }
}