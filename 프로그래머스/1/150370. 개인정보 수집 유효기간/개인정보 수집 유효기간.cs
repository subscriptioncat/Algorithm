using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> list = new List<int>();
        int termsLength = terms.Length;
        int privaciesLength = privacies.Length;
        Dictionary<char, int> termsDic = new Dictionary<char, int>();

        DateTime todayDT = DateTime.Parse(today);
        DateTime dateTime = new DateTime();

        for (int i = 0; i < termsLength; i++)
        {
            termsDic.Add(terms[i][0], int.Parse(terms[i].Substring(2)));
        }

        for (int i = 0; i < privaciesLength; i++)
        {
            DateTime.TryParse(privacies[i].Substring(0, 10), out dateTime);
            dateTime = dateTime.AddMonths(termsDic[privacies[i][11]]);
            if (todayDT >= dateTime)
            {
                list.Add(i + 1);
            }
        }
        return list.ToArray();
    }
}