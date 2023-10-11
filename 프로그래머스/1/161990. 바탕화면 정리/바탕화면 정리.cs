using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int row = wallpaper.Length;
        int column = wallpaper[0].Length;

        int minRow = row;
        int maxRow = 0;
        int minColumn = column;
        int maxColumn = 0;
        for (int i = 0 ; i < row; i++)
        {
            int ArrayMinColumn = wallpaper[i].IndexOf('#');
            if(ArrayMinColumn > -1)
            {
                int ArrayMaxColumn = wallpaper[i].LastIndexOf('#');
                minRow = minRow <= i ? minRow : i;
                maxRow = maxRow >= i ? maxRow : i;
                minColumn = minColumn <= ArrayMinColumn ? minColumn : ArrayMinColumn;
                maxColumn = maxColumn >= ArrayMaxColumn ? maxColumn : ArrayMaxColumn;
            }
        }
        answer[0] = minRow;
        answer[1] = minColumn;
        answer[2] = maxRow + 1;
        answer[3] = maxColumn + 1;
        return answer;
    }
}