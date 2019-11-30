class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        var answer = -1;

        for (var i = 2; i < A.Length; i++)
        {
            var ap = A[i - 2];
            var aq = A[i - 1];
            var ar = A[i];

            var sum = ap + aq;
            if (sum > ar)
            {
                answer = ap + aq + ar;
            }
        }

        return answer;
    }
}