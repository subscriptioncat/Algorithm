using System;

public class Solution {
    public int solution(int[,] sizes) {
        int width = 0;
        int height = 0;
        for (int i  = 0; i < sizes.GetLength(0);  i++)
        {
            int max = 0;
            int min = 0;
            if(sizes[i, 0] >= sizes[i, 1])
            {
                max = sizes[i, 0];
                min = sizes[i, 1];
            }
            else
            {
                max = sizes[i, 1];
                min = sizes[i, 0];
            }
            width = Math.Max(width, max);
            height = Math.Max(height, min);
        }
        return width * height;
    }
}