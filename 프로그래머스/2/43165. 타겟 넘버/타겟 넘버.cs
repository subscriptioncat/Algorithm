using System;
using System.Linq;
public class Solution 
{
    int answer;
    bool[] visitArray;
    int[] numberArray;
    int numberArrayLength;
    
    public int solution(int[] numbers, int target) 
    {
        int sum = numbers.Sum();
        int k = (sum - target) / 2;
        
        answer = 0;
        numberArray = numbers.Where(x => x <= k).ToArray();
        numberArrayLength = numberArray.Length;
        visitArray = new bool[numberArrayLength];
        
        Dfs(k, 0);
        return answer = answer == 0 ? 1 : answer;
    }
    
    public void Dfs(int target, int count)
    {
        for(int i = count; i < numberArrayLength; i++)
        {
            if (!visitArray[i] && target >= numberArray[i])
            {
                visitArray[i] = true;
                Dfs(target - numberArray[i], i);
                visitArray[i] = false;
            }
        } 
        if(target == 0)
            answer++;
    }
}