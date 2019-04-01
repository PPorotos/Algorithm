using System;
using System.Collections.Generic;
namespace Algorithm.Algorithm
{

    //제일작은수 제거하기
    public class Solution10
    {

        public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();
            int min = 999;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }

            if (arr.Length == 1)
            {
                answer = new int[] { -1 };
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] != min)
                    {
                        list.Add(arr[i]);
                    }
                }
                answer = new int[arr.Length - 1];
                answer = list.ToArray();

            }

            return answer;

        }


    }
}
