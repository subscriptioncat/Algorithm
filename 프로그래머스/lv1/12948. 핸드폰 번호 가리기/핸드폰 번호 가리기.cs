using System.Text;
public class Solution {
    public string solution(string phone_number) {
        StringBuilder stringBuilder = new StringBuilder(phone_number);
        for(int i = 0; i < phone_number.Length - 4 ; i++)
        {
            stringBuilder[i] = '*';
        }
        return stringBuilder.ToString();
    }
}