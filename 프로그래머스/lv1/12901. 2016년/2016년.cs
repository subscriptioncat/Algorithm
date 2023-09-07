using System;
using System.Globalization;
public class Solution {
    public string solution(int a, int b) {
        DateTime dateValue = new DateTime(2016, a, b);
        return dateValue.ToString("ddd", new CultureInfo("en-US")).ToUpper();
    }
}