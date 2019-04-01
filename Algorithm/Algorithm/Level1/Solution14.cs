using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm
{

    //소수찾기 - 에라토스테네스의 체
    public class Solution14
    {

        public int solution(int n)
        {
            int answer = 0;
            bool[] boolean = new bool[n + 1];

            for(int i = 2; i <= n; i++)
            {
                if(boolean[i] == false)
                {
                    answer++;
                    for(int j = i; j <= n; j += i)
                    {
                        boolean[j] = true;
                    }
                }
            }
            return answer;

        }


    }
}
