public class Solution {
    public bool solution(string s) {
        if (s.Length == 4 || s.Length == 6) 
        {
            return int.TryParse(s, out int result);
        }
        return false;
    }
}