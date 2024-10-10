using System;
using System.Linq;
class Solution 
{
    public int solution(int n) 
   {
        int oneCount = Convert.ToString(n,2).Count(x => x == '1');
        while (true)
        {
            if (Convert.ToString(++n, 2).Count(x => x == '1') == oneCount)
                break;
        }

        return n;
    }
}