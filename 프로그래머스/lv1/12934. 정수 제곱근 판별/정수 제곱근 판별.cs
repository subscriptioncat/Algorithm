using System;
public class Solution {
    public long solution(long n) {
        return Math.Floor(Math.Sqrt(n)) == Math.Sqrt(n) ? (long)Math.Pow((Math.Sqrt(n)+1),2) : -1;
    }
}