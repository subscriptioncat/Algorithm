using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        List<string> container = new List<string>();
        int discountLength = discount.Length;
        int answer = 0;
        for (int i = 0; i < discountLength; i++) 
        {
            int index = Array.IndexOf(want, discount[i]);
            if (index > -1)
            {
                if(container.Where(x => x.Equals(discount[i])).Count() == number[index])
                    container.RemoveRange(0, container.IndexOf(discount[i]) + 1);

                container.Add(discount[i]);

                if (container.Count == 10)
                {
                    container.RemoveAt(0);
                    answer++;
                }
            }
            else
                container.Clear();
        }
        return answer;
    }
}