using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int result = 0;
        int remain = 0;
        while(n >= a){
            remain = n % a;
            result = (n / a) * b;
            answer += result;
            n = result + remain;
        }
        return answer;
    }
}