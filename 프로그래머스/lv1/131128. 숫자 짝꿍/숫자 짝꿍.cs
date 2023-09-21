using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        List<char> charList = new List<char>();
        if(X.Length >= Y.Length)
        {
            foreach (char c in X)
            {
                if (Y.Length == 0)
                    break;
                int YIndex = Y.IndexOf(c);
                if (YIndex >= 0)
                {
                    charList.Add(c);
                    Y = Y.Remove(YIndex, 1);
                }
            }
        }
        else
        {
            foreach (char c in Y)
            {
                if (X.Length == 0)
                    break;
                int XIndex = X.IndexOf(c);
                if (XIndex >= 0)
                {
                    charList.Add(c);
                    X = X.Remove(XIndex, 1);
                }
            }
        }
            
        if(charList.Count == 0)
            return "-1";
        charList.Sort((n1, n2) => n2.CompareTo(n1));
        string answer = int.Parse(new string(charList.ToArray())).ToString();

        return answer;
    }
}