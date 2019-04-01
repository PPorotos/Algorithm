using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm
{
    //K번째 수
    public class Solution16
    {
        public int[] solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int first = commands[i, 0]-1;
                int last = commands[i, 1]-1;
                int length = last - first;
                int listAdd = commands[i, 2]-1;

                List<int> list = new List<int>();
                for(int j = 0; j <= length; j++)
                {
                    list.Add(array[first + j]);
                }
                list.Sort();
                answer.Add(list[listAdd]);
            }

            for(int i = 0; i<answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
            return answer.ToArray();
        }
    }
}
