public class Solution {
    public string solution(string s) {
        string answer = "";
        foreach (string arg in s.ToLower().Split(' '))
        {
            if (arg != "")
            {
                char c = arg[0];
                c = ((c >= 'a' && c <= 'z') ? (char)(c - 32) : c);
                answer += string.Format("{0}{1} ", c, arg.Substring(1));
            }
            else
            {
                answer += " ";
            }
        }
        return answer.Substring(0,answer.Length - 1);
    }
}