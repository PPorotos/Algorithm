using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm.Level2
{
    //쇠막대기
    public class Solution2_5
    {
        public int solution(string arrangement)
        {
            int answer = 0;

            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < arrangement.Length; i++)
            {
                if (i == 0)
                {
                    stack.Push(arrangement[i]);
                }
                else if (arrangement[i].Equals(')') && arrangement[i - 1].Equals('('))
                {
                    stack.Pop();
                    answer += stack.Count;
                }else if(arrangement[i].Equals(')') && arrangement[i - 1].Equals(')'))
                {
                    stack.Pop();
                    answer += 1;
                }
                else
                {
                    stack.Push(arrangement[i]);
                }
            }

            return answer;
        }

    }
}
