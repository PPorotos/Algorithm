using System;
namespace Algorithm.Algorithm
{
    //하샤드 수
    public class Solution7
    {
      
        public bool solution(int n)
        {
            bool answer = true;
            int sum = 0;
            int value = n;
            while(n != 0)
            {
                sum += n % 10;

                n /= 10;
            }

          
            if (value % sum == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }
     
      
    }
}
