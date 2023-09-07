using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        List<string> cards1List = new List<string>(cards1.ToList());
        List<string> cards2List = new List<string>(cards2.ToList());
        cards1List.Add("0");
        cards2List.Add("0");
        int result = 0;
        for(int i = 0; i <goal.Length; i++)
        {
            if (cards1List[0] == goal[i])
            {
                result++;
                cards1List.Remove(goal[i]);
            }
            else if (cards2List[0] == goal[i])
            {
                result++;
                cards2List.Remove(goal[i]);
            }
            else
            {
                break;
            }
        }
        return result == goal.Length ? "Yes" : "No";
    }
}