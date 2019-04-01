using System;
namespace Algorithm.Algorithm
{
    //행열의 합
    public class Solution5
    {
        public void solution() 
        {
            int[,] arr1 = { { 1 },{ 2 } };
            int[,] arr2 = { { 3 }, { 4 } };

            int n1 = arr1.GetLength(0);
            int n2 = arr1.GetLength(1);

            int[,] answer = new int[n1, n2];

            for(int i = 0; i<n1; i++)
            {
                for(int j =0; j<n2; j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                    Console.WriteLine(answer[i, j]);
                }
            }
        }


    }
}
