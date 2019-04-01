using System;
namespace Algorithm.Algorithm
{
    //정수 제곱근 판별
    public class Solution13_1
    {
        public long solution(long n)
        {
            var n_sqrt = Math.Sqrt(n);

            long answer = (long)(n_sqrt % 1.0 == 0 ? (n_sqrt + 1) * (n_sqrt + 1) : -1);

            return answer;
        }
       
    }
}
