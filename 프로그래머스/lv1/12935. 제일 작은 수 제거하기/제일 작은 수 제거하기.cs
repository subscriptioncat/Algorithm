using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int arrMin = arr.Min();
        return arr.Where(n => n != arrMin).Count() == 0 ? new int[] {-1} : arr.Where(n => n != arrMin).ToArray();
            
    }
}