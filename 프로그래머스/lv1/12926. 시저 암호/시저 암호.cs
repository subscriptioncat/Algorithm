using System.Text;
public class Solution {
    public string solution(string s, int n) {
        StringBuilder sb = new StringBuilder(s);
        for(int i = 0; i < s.Length; i++)
        {
            if (((byte)sb[i]) >= 65 && ((byte)sb[i]) <= 90)
            {
                sb[i] = ((byte)sb[i]) + n > 90 ? (char)(64 + (((byte)sb[i]) + n)-90) : (char)(((byte)sb[i]) + n);
            }
            else if(((byte)sb[i]) >=97 && ((byte)sb[i]) <= 122)
            {
                sb[i] = ((byte)sb[i]) + n > 122 ? (char)(96 + (((byte)sb[i]) + n)-122) : (char)(((byte)sb[i]) + n);
            }
        }
        string answer = sb.ToString();
        return answer;
    }
}