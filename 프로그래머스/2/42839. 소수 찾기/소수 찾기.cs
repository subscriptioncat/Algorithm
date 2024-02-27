using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    bool[] visitArr;
    int[] numberArr;
    int numberArrLength;
    HashSet<int> hs;
    
    public int solution(string numbers) 
    {
        numberArr = numbers.Select(item => (int)char.GetNumericValue(item)).ToArray();
        numberArrLength = numberArr.Length;
        visitArr = new bool[numberArrLength];
        hs = new HashSet<int>();
        DFSPlay(0);
        Filtering();
        return GetHashSetCount();
    }
    
    public void DFSPlay(int num)
    {
        for (int i = 0; i < numberArrLength; i++)
        {
            if (!visitArr[i])
            {
                num *= 10;
                num += numberArr[i];
                visitArr[i] = true;

                hs.Add(num);
                DFSPlay(num);

                visitArr[i] = false;
                num /= 10;
            }
        }
    }

    public int GetHashSetCount()
    {
        return hs.Count;
    }

    public void Filtering()
    {
        int max = hs.Max();
        bool[] isPrime = new bool[max+1];
        hs.Remove(0);
        hs.Remove(1);
        for (int i = 2; i * i <= max; i++)
        {
            if (!isPrime[i])
            {
                for (int j = i * i; j <= max; j += i)
                {
                    isPrime[j] = true;
                    hs.Remove(j);
                }
            }
        }
    }
}