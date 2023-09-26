using System;
using System.Text;
public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        int maxIndex = babbling.Length;
        int type = 0;
        for(int i = 0; i < maxIndex; i++)
        {
            Console.WriteLine("현재 answer : {0}",answer);
            StringBuilder sb = new StringBuilder(babbling[i]);
            type = 0;
            int nowLenght = sb.Length;
            int j = 0;
            while (true)
            {
                if (nowLenght == j)
                {
                    answer++;
                    break;
                }
                else if(nowLenght == j+1)
                    break;
                else if (nowLenght == j + 2)
                {
                    if (sb[j] == 'y' && sb[j + 1] == 'e' && type != 2)
                        answer++;

                    else if (sb[j] == 'm' && sb[j + 1] == 'a' && type != 4)
                        answer++;

                    break;
                }
                else
                {
                    if (sb[j] == 'a' && sb[j + 1] == 'y' && sb[j + 2] == 'a' && type != 1)
                    {
                        j += 2;
                        type = 1;
                    }
                    else if (sb[j] == 'y' && sb[j + 1] == 'e' && type != 2)
                    {
                        j += 1;
                        type = 2;
                    }
                    else if (sb[j] == 'w' && sb[j + 1] == 'o' && sb[j + 2] == 'o' && type != 3)
                    {
                        j += 2;
                        type = 3;
                    }
                    else if (sb[j] == 'm' && sb[j + 1] == 'a' && type != 4)
                    {
                        j += 1;
                        type = 4;
                    }
                    else
                        break;
                }
                j++;
            }
        }
        return answer;
    }
}