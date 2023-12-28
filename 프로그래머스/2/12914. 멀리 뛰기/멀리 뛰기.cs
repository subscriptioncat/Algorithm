public class Solution {
    public long solution(int n) {
        int answer = 0;

            // F(1) = 1, F(2) = 2, F(3) = 3
            if (n <= 3)
                return n;

            int dp1 = 2; // F(2)
            int dp2 = 3; // F(3)

            // F(4)부터 구함
            for (int i = 4; i <= n; i++)
            {
                // 1234567보다 커지면 나머지를 저장
                answer = (dp1 + dp2) % 1234567;

                // 다음 연산을 위한 세팅
                dp1 = dp2;
                dp2 = answer;
            }

            return answer;
    }
}