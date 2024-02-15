using System;

public class Solution {
    public int solution(int n, int k) {
        double number = 0;
        int i = 0;
        int remainder;
        int answer = 0;
        while (n != 0)
        {
            if ((remainder = n % k) != 0)
            {
                number += Math.Pow(10, i) * remainder;
                i++;
            }
            else
            {
                if (PrimeNumber(number))
                    answer++;
                i = 0;
                number = 0;
            }
            n /= k;
        }
        if (PrimeNumber(number))
            answer++;
        return answer;
    }
    
    public bool PrimeNumber(double target)
    {
        if(target <= 1)
            return false;
        int n = (int)Math.Sqrt(target);
        for(int i = 2; i <= n; i++)
        {
            if (target % i == 0)
                return false;
        }
        return true;
    }
}