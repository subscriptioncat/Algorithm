using System;

public class Solution {
    public int solution(string word) {
        char[] charArr = word.ToCharArray();
        int answer = 0;
        int number = 781;
        for (int i = 0; i < charArr.Length; i++)
        {
            switch((int)charArr[i])
            {
                case 65:
                    answer++;
                    break;
                case 69:
                    answer += number + 1;
                    break;
                case 73:
                    answer += number * 2 + 1;
                    break;
                case 79:
                    answer += number * 3 + 1;
                    break;
                default:
                    answer += number * 4 + 1;
                    break;
            }
            number /= 5;
        }
        return answer;
    }
}