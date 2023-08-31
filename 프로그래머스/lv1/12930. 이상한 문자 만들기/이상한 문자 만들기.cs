public class Solution {
    public string solution(string s) {
        string answer = "";
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            count = s[i] == ' ' ? 0 : count + 1;
            answer += count % 2 == 1 ? s.ToUpper()[i] :  s.ToLower()[i];
        }
        return answer;
    }
}