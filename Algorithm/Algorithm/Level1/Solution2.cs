using System;

//예산
namespace Algorithm.Algorithm
{
    public struct Solution2
    {
        public int Solution(int[] n, int budget)
        {
            int answer = 0;

            Array.Sort(n);

            for(int i = 0; i < n.Length; i++)
            {
                budget -= n[i];
                if(budget < 0)
                {
                    return answer;
                }

                answer++;
                
            }
            return answer;

        }

    }

}
