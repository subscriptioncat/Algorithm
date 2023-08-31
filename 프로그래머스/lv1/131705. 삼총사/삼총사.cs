using System;
using System.Linq;
public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for(int x = 0; x < number.Count(); x++){
            for(int y = x + 1; y < number.Count(); y++){
                for(int z = y + 1; z < number.Count(); z++){
                    answer += number[x] + number[y] + number[z] == 0 ? 1 : 0;
                }
            }
        }
        return answer;
    }
}