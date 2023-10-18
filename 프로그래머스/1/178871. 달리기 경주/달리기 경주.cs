using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++) { dic.Add(players[i], i); }
        
        foreach(string call in callings)
        {
            int rank = dic[call];
            string overtake = players[rank - 1];
            
            players[rank - 1] = call;
            players[rank] = overtake;
            
            dic[call] = rank - 1;
            dic[overtake] = rank;
        }
        return players;
    }
}