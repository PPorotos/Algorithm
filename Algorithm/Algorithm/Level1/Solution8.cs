using System;
namespace Algorithm.Algorithm
{   
    //최대공약수와 최소공배수
    public class Solution8
    {
        public Solution8()
        {

        }


        public int gcd(int n, int m)
        {
            int tmp = 0;

            while (true)
            {
                if(m % n == 0)
                {
                    return n;

                }

                tmp = n;
                n = m % n;
                m = n;
            }
        }
        public int lcm(int n, int m)
        {
            return n * m / gcd(n,m);
        }

        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            answer[0] = gcd(n, m);
            answer[1] = lcm(n, m);

            return answer;

        }
       
    }
}
