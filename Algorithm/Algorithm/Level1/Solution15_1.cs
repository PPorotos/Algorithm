using System;
using System.Linq;

namespace Algorithm.Algorithm
{
    //문자열 내맘대로 정하기
    public class Solution15_1
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = strings.OrderBy(c => c).ToArray();
            answer = answer.OrderBy(c => c[n]).ToArray();


            for(int i=0; i<answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
            return answer;

        }
       
    }
}
