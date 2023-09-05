using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new List<int>();
        int MaxCount = numbers.Length;
        for(int i = 0; i < MaxCount; i++)
        {
            for(int j = i+1; j < MaxCount; j++)
                list.Add(numbers[j] + numbers[i]);
        }
        list.Sort();
        return list.Distinct().ToArray();
    }
}