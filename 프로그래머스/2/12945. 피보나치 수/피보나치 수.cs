using System;
public class Solution {
    public int solution(int n) {
        int number1 = 0;
        int number2 = 1;
        int returnValue = 0;
        int divValue = 1234567;
        if (n < 2)
            return n;

        for (int i = 2; i <= n; i++)
        {
            returnValue = number1 + number2;
            if (returnValue > 1234567)
                returnValue %= 1234567;
            number1 = number2;
            number2 = returnValue;
        }
        return (int)(returnValue % divValue);
    }
}