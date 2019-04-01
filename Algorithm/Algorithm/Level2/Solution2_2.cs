using System;
namespace Algorithm.Algorithm.Level2
{
    //탑
    public class Solution2_2
    {
         public int[] solution(int[] heights)
         {
            int[] answer = new int[heights.Length];
            bool check = false;
            for (int i = 0; i < heights.Length; i++)
            {
                if (i == 0)
                {
                    answer[i] = 0;
                }
                else
                {
                    for (int j = i-1; j > 0; j--)
                    {
                        if (heights[j] > heights[i])
                        {
                            answer[i] = j + 1;
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        answer[i] = 0;
                    }
                }
            }

            return answer;
        }
       
    }
}
