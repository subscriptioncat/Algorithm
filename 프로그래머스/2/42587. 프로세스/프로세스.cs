using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        List<int> list = new List<int>(priorities);

        while (list.Count != 0)
        {
            int index = list.IndexOf(list.Max<int>());
            if (index == location)
            {
                answer++;
                break;
            }

            list.AddRange(list.GetRange(0, index));
            list.RemoveRange(0, index + 1);
            location = index > location ? list.Count + (location - index) : location - index - 1;
            answer++;
        }
        return answer;
    }
}