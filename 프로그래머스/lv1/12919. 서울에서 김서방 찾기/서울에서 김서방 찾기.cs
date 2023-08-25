using System;
public class Solution {
    public string solution(string[] seoul) {
        
        return string.Format("김서방은 {0}에 있다", Array.IndexOf(seoul, "Kim"));
    }
}