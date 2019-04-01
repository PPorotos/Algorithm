using System;
using System.Collections.Generic;
namespace Algorithm.Algorithm.Level2
{
    //다리를 지나는 트럭 
    public class Solution2_4
    {
        public int solution(int bridge_length, int weight, int[] truck_weigths)
        {
            int answer = 0;

            Queue<int> q = new Queue<int>();

            int weight_sum = 0;

            foreach(var truck_weight in truck_weigths)
            {
                while (true)
                {
                    if(q.Count == 0)
                    {
                        q.Enqueue(truck_weight);
                        answer += 1;
                        weight_sum = truck_weight;
                        break;
                    }else if(q.Count == bridge_length)
                    {
                        weight_sum -= q.Peek();
                        q.Dequeue();
                    }
                    else
                    {
                        if(weight_sum + truck_weight > weight)
                        {
                            q.Enqueue(0);
                            answer += 1;
                        }
                        else
                        {
                            q.Enqueue(truck_weight);
                            answer += 1;
                            weight_sum += truck_weight;
                            break;
                        }
                    }
                }
            }
            return answer + bridge_length;
        }


    }
}
