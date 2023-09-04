using System;
using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        return strings.OrderBy(x => x[n]).ThenBy(x => x).ToArray();
    }
}