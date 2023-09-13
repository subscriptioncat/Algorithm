using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
         int[] answer = new int[2];
         int count = 0;
         int zeroCount = 0;
         for(int i = 0; i < lottos.Length; i++)
         {
             if(lottos[i] == 0)
             {
                 zeroCount++;
             }
             else
             {
                for(int j = 0; j < win_nums.Length; j++)
                {
                    if(win_nums[j] == lottos[i]){
                        count++;
                        break;
                    }
                }
             }
         }
         answer[0] = 7- (count + zeroCount) == 7 ? 6 : 7 - (count + zeroCount);
         answer[1] = 7- count == 7 ? 6 : 7 - count;
        return answer;
    }
}