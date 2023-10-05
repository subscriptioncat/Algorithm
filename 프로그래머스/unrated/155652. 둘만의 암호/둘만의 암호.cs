using System;
using System.Text;
public class Solution {
    public string solution(string s, string skip, int index) {
        int sLength = s.Length;
        int skipLength = skip.Length;
        StringBuilder sb = new StringBuilder(s);
        int count = 0;

        for(int i = 0; i < sLength;)
        {
            sb[i]++;
            for(int j = 0; j < skipLength; j++)
            {
                if (sb[i] == skip[j])
                {
                    sb[i]++;
                    j = -1;
                }
                if (sb[i] > 'z')
                    sb[i] = (char)(sb[i] - 26);
            }
            count++;
            if (count == index)
            {
                count = 0;
                i++;
            }
        }
        return sb.ToString();
    }
}