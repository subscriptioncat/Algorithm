using System;

public class Solution {
    public int solution(string s) {
        foreach (NumList n in  Enum.GetValues(typeof(NumList)))
    s= s.Replace(n.ToString(), ((int)n).ToString());
        return int.Parse(s);
    }
}
public enum NumList
{
    zero = 0,
    one, 
    two,
    three, 
    four, 
    five, 
    six, 
    seven,
    eight, 
    nine
}