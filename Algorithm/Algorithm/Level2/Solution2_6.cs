using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm.Level2
{
    //프린터
    public class Solution2_6
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;
            bool check = true;

            Queue<int> q = new Queue<int>(priorities);

             while(q.Count != 0)
            {
                for (int j = 0; j < q.Count; j++)
                {
                    List<int> temp = new List<int>(q.ToArray());
                    if (q.Peek() < temp[j])
                    {
                        q.Enqueue(q.Peek());
                        q.Dequeue();
                        if(location == 0)
                        {
                            location = q.Count - 1;
                        }
                        else
                        {
                            location -= 1;
                        }
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    if(location == 0)
                    {
                        q.Dequeue();
                        answer+=1;
                        break;
                    }
                    else 
                    {
                        q.Dequeue();
                        answer += 1;
                        location -= 1;
                    }
                }
                else
                {
                    check = true;
                }
            }
            return answer;
        }
     
    }
}
