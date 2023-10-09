using System;
using System.Collections;
public class Solution {
    public int solution(int[] ingredient) {
        Stack stackNum = new Stack();
        Stack validValue = new Stack();
        int ingredientLength = ingredient.Length;
        int[] answerNumber = { 1, 2, 3, 1 };
        int answerNumberIndex = 0;
        int answer = 0;

        for(int i = 0; i < ingredientLength; i++)
        {
            stackNum.Push(ingredient[i]);
            if(ingredient[i] == 1 || ingredient[i] == answerNumber[answerNumberIndex])
            {
                validValue.Push(true);
                if(answerNumberIndex == 3)
                {
                    answer++;
                    for (int j = 0; j < 4; j++)
                    {
                        stackNum.Pop();
                        validValue.Pop();
                    }

                    if(validValue.Count != 0)
                    {
                        if ((bool)validValue.Peek())
                            answerNumberIndex = (int)stackNum.Peek();
                        else
                            answerNumberIndex = 0;
                    }
                    else
                        answerNumberIndex = 0;

                }
                else
                    answerNumberIndex = ingredient[i];
            }
            else
            {
                validValue.Push(false);
                answerNumberIndex = 0;
            }
        }
        return answer;
    }
}