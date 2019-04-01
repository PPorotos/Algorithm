using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm.Level2
{
    //기능 개발
    public class Solution2_3
    {
        public int[] solution(int[] progresses,int[] speeds)
        {
            List<int> answer = new List<int>();
            int temp = 0;
            int[] d_day = new int[progresses.Length];
            int count = 1;

            for(int i = 0; i<progresses.Length; i++)
            {
                if((100-progresses[i])%speeds[i] == 0)
                {
                    d_day[i] = (100 - progresses[i]) / speeds[i];
                }
                else
                {
                    d_day[i] = (100 - progresses[i]) / speeds[i] + 1;
                }
            }

            temp = d_day[0];
            for(int i = 1; i < d_day.Length; i++)
            {
                if(temp >= d_day[i])
                {
                    count += 1;
                }
                else
                {
                    temp = d_day[i];
                    answer.Add(count);
                    count = 1;
                }
            }
            answer.Add(count);
          
            return answer.ToArray();
        }

    }
}
