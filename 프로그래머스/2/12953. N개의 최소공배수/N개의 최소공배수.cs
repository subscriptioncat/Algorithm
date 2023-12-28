using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] arr) {
        Dictionary<int, int> commonDivisorDic = new Dictionary<int, int>();
        int arrLength = arr.Length;
        int answer = 1;
        for (int i  = 0; i < arrLength; i++)
        {
            for (int n = 2; n <= arr[i]; n++)
            {
                int count = 0;
                while (arr[i] % n == 0)
                {
                    count++;
                    arr[i] = arr[i] / n;
                    if (commonDivisorDic.ContainsKey(n))
                    {
                        if (commonDivisorDic[n] < count)
                            commonDivisorDic[n] = count;
                    }
                    else
                        commonDivisorDic.Add(n, count);
                }
            }
        }

        if (commonDivisorDic.Count != 0)
        {
            foreach (KeyValuePair<int, int> keyValuePair in commonDivisorDic)
                answer *= (int)Math.Pow((int)keyValuePair.Key, (int)keyValuePair.Value);    
        }
        return answer;
    }
}