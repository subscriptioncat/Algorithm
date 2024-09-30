using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
    {
        //1. "prev" 입력시 10초 전으로 이동, 10초미만일 경우 0분 0초로 이동
        //2. "next" 입력시 10초 후로 이동, 남은시간이 10초 미만일 경우 마지막 위치로 이동(마지막 위치는 동영상 길이와 일치)
        //3. 오프닝 건너뛰기는 현재위치가 오프닝 구간일 경우 오프닝이 끝나는 위치로 이동
        //오프닝 건너뛰기는 처음과 마지막에 검사해서 뛰어넘을 수 있습니다.
        string prev = "prev";

        //문자열을 숫자로 변환
        int videoLenNum = Array.ConvertAll(video_len.Split(':'), s => int.Parse(s))
            .Select((n, index) => index == 0 ? n * 60 : n).Sum();
        int posNum = Array.ConvertAll(pos.Split(':'), s => int.Parse(s))
            .Select((n, index) => index == 0 ? n * 60 : n).Sum();
        int startNum = Array.ConvertAll(op_start.Split(':'), s => int.Parse(s))
            .Select((n, index) => index == 0 ? n * 60 : n).Sum();
        int endNum = Array.ConvertAll(op_end.Split(':'), s => int.Parse(s))
            .Select((n, index) => index == 0 ? n * 60 : n).Sum();

        posNum = CheckTheOpening(posNum, startNum, endNum);
        foreach(string str in commands)
        {
            if(str.Equals(prev))
                posNum = posNum > 10 ? posNum - 10 : 0;
            else
                posNum = posNum + 10 > videoLenNum ? videoLenNum : posNum + 10;
            posNum = CheckTheOpening(posNum, startNum, endNum);
        }
        return Min_Sec_Conversion(posNum);
    }

    private int CheckTheOpening(int pos, int op_start, int op_end)
    {
        if (op_start <= pos && pos < op_end)
            return op_end;
        else
            return pos;
    }

    private string Min_Sec_Conversion(int pos)
    {
        int min = (pos / 60);
        int sec = (pos % 60);
        return $"{min:D2}:{sec:D2}";
    }
}