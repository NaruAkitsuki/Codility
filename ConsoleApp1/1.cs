class Solution
{
    public int solution(int[] A)
    {
        var answer = 0;
        var node = 0;
        while (node != -1)
        {
            node = A[node];
            answer++;
        }
        return answer;
    }
}