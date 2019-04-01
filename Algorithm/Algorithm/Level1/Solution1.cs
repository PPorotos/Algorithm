using System;


//x만큼 간격이 있는 n개의 숫자
namespace Algorithm
{
    public class Solution1
    {
        public long[] Solution(int x, int n)
        {
            long[] answer = new long[n]; 

            int add = 0;
            for(int i = x; i < n; i++)
            {
                int j = 0;
                add += i;
                answer[j] = add;
                j++;
            }
            return answer;
    
        
         }


    }

}
