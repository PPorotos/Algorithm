using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm
{

    //체육복
    public class Solution17
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            List<int> lostNum = new List<int>(lost);
            List<int> reserveNum = new List<int>(reserve);
            List<int> test = new List<int>();

            for(int i = 0; i < reserveNum.Count; i++)
            {
                if (lostNum.Contains(reserveNum[i]))
                {
                    lostNum.Remove(reserveNum[i]);
                    test.Add(reserveNum[i]);
                }
            }

            for(int i = 0; i < test.Count; i++)
            {
                reserveNum.Remove(test[i]);
            }

            for(int i = 0; i<reserveNum.Count; i++)
            {
                if (lostNum.Contains(reserveNum[i] - 1))
                {
                    lostNum.Remove(reserveNum[i]-1);
                }else if (lostNum.Contains(reserveNum[i] + 1))
                {
                    lostNum.Remove(reserveNum[i] + 1);
                }
            }
            answer = n - lostNum.Count;

            return answer;
        }

    }
}
