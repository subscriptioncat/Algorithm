using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> list = new List<int>(); 
        for(int i =  0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
                list.Add(arr[i]);
        }
        list.Sort();
        return list.Count == 0 ?  new int[] {-1} : list.ToArray();
    }
}