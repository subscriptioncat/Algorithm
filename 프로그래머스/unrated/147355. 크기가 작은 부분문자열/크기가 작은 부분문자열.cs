using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long tLenght = t.Length;
        long pLenght = p.Length;
        long Count = tLenght - pLenght;
        for (long i = 0; i <= Count; i++)
            answer += long.Parse(t.Substring((int)i, (int)pLenght)) <= long.Parse(p) ? 1 : 0;
        return answer;
    }
}