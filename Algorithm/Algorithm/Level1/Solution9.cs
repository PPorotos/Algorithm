using System;
namespace Algorithm.Algorithm
{
    //콜라스 추축
    public class Solution9
    {

        public int solution(long num)
        {
            int answer = 0;

            while(true)
            {
                if(num == 1)
                {
                    break;
                }
                if (answer > 500)
                {
                    return -1;
                }
                if(num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }
                answer++;
            }
            return answer;
        }

    }
}
