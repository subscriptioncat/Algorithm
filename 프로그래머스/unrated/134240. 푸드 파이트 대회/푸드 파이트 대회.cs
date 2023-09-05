using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        answer = Arrangement(food, answer, 1);
        return answer;
    }
    public string Arrangement(int[] food, string answer ,int Index)
    {
        for(int i = 0; i < food[Index]/2 ; i++) 
            answer += Index;

        if(Index== food.Length -1)
            answer += 0;
        else
            answer = Arrangement(food, answer, Index + 1);

        for (int i = 0; i < food[Index] / 2; i++)
            answer += Index;

        return answer;
    }
}