using System;
namespace Algorithm.Algorithm
{
    //평균구하기
    public struct Solution4
    {
        public double solution(int[] arr)
        {
            double answer = 0;

            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            answer = (double)sum / (double)arr.Length;
            return answer;
        }

        //private static void Main()
        //{
        //    Solution4 s4 = new Solution4();
        //    Console.WriteLine(s4.solution(new int[] { 1, 2, 3, 4 }));
        //}
    }
}
