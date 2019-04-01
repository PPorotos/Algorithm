using System;
namespace Algorithm.Algorithm
{
    //문자열 내마음대로 정하기
    public class Solution15
    {
         public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };
            string temp = "";

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings.Length - i - 1; j++)
                {
                    if(strings[j][n] > strings[j + 1][n])
                    {
                        temp = strings[j];
                        strings[j] = strings[j + 1];
                        strings[j + 1] = temp;
                    }
                    else if(strings[j][n] == strings[j + 1][n])
                    {
                        if(String.Compare(strings[j],strings[j+1]) > 0)
                        {
                            temp = strings[j];
                            strings[j] = strings[j + 1];
                            strings[j + 1] = temp;
                        }
                    }
                }
            }
            answer = strings;

            return answer;
        }

    }
}
