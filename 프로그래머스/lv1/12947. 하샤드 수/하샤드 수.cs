using System;
public class Solution {
    public bool solution(int x) {
        int sum = 0;
        int n = x;
        for(int i = 0; i < Math.Log10(x)+1; i++)
        {
            sum += n % 10;
            n /= 10;
        }
        return x % sum == 0 ? true : false;
    }
}