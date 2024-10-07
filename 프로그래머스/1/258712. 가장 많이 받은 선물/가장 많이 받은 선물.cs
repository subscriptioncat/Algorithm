using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts)
    {
        int friendsLength = friends.Length;
        Dictionary<string, Dictionary<string, int>> giftFriendDic = friends.ToDictionary(
            person => person,
            person => friends.Where(name => name != person)
                           .ToDictionary(name => name, name => 0)
        );

        Dictionary<string, int> giftQuotient = friends.ToDictionary(name => name, name => 0);

        int giftsLength = gifts.Length;
        for(int i = 0; i < giftsLength; i++)
        {
            string[] str = gifts[i].Split(' ');

            giftFriendDic[str[0]][str[1]]++;
            giftQuotient[str[0]]++;
            giftQuotient[str[1]]--;
        }

        int controlPoint = 0;
        int skipIndex = 0;
        Dictionary<string, int> receivedFriendsDic = friends.ToDictionary(name => name, name => 0);

        foreach (var giftFriend in giftFriendDic)
        {
            skipIndex = controlPoint++;
            foreach (var receivedFriend in giftFriend.Value)
            {
                if(skipIndex-- > 0)
                    continue;

                if (receivedFriend.Value > giftFriendDic[receivedFriend.Key][giftFriend.Key])
                    receivedFriendsDic[giftFriend.Key]++;
                else if(receivedFriend.Value < giftFriendDic[receivedFriend.Key][giftFriend.Key])
                    receivedFriendsDic[receivedFriend.Key]++; 
                else
                {
                    if(giftQuotient[giftFriend.Key] > giftQuotient[receivedFriend.Key])
                        receivedFriendsDic[giftFriend.Key]++;
                    else if(giftQuotient[giftFriend.Key] < giftQuotient[receivedFriend.Key])
                        receivedFriendsDic[receivedFriend.Key]++;
                }
            }
        }
        return receivedFriendsDic.Values.Max();
    }
}