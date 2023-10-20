using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
        List<int> list = new List<int>();

        foreach(string arg in s.Split(' '))
        {
            list.Add(int.Parse(arg));
        }

        list.Sort();
        string answer = list.First().ToString() + ' '+ list.Last().ToString();
        
        return answer;
    }
}