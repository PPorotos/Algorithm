using System;
namespace Algorithm.Algorithm
{
    //정수 제곱근 판별
    public class Solution13
    {
        public long solution(long n)
        {
            long answer = 0;

            var temp = Math.Sqrt(n);

            if(temp - (int)temp == 0)
            {
                temp++;
                answer = (long)(temp * temp);
            }
            else
            {
                return -1;
            }
            return answer;
        }

    }
}
