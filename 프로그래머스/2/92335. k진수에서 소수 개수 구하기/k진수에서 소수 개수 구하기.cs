using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        string numberString = "";


        /*진수 변환*/
        while(n > 0)
        {
            int t = n / k;
            int mod = n % k;            
            numberString = mod.ToString() + numberString;            
            n = t;
        }       


        /*정규식*/       

        Regex matchNumber = new Regex(@"0?[1-9]+0?");
        MatchCollection resultColl = matchNumber.Matches(numberString);


        foreach(Match m in resultColl)
        {
            if(m.Value.Replace("0","") != "")
            {
                long num = Convert.ToInt64(m.Value.Replace("0",""));

                if(num > 1)
                {
                    if(isPrime(num)) answer++;            
                }
            }
        }             



        return answer;
    }

    public bool isPrime(long num)
    {
        int nr = (int)Math.Sqrt(num);
        for(int i = 2; i <= nr; i++)
        {
            if(num%i == 0)
                return false;
        }
        return true;
    }
}