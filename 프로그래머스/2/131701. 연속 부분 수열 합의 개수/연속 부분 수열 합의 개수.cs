using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] elements) {
            List<int> list = new List<int>(elements);
            HashSet<int> hashSet = new HashSet<int>();
            
            // elements를 한번 더 넣어서 따로 끝 인덱스를 0번과 이어주지 않게 함
            for (int i = 0; i < elements.Length - 1; i++)
                list.Add(elements[i]);

            for (int i = 0; i < elements.Length; i++)
            {
                int num = 0;
                for (int j = 0; j < elements.Length; j++)
                {
                    num += list[i + j]; // 현재 인덱스 + 더해나갈 인덱스
                    hashSet.Add(num);
                }
            }

            return hashSet.Count;
    }
}