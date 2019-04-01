using System;
namespace Algorithm.Algorithm
{
    //이상한 문자만들기
    public class Solution11
    {
        public string solution(string s)
        {
            string answer = "";

            string[] temp_string = s.Split(' ');

            char[] temp = new char[] { };

            for(int i = 0; i < temp_string.Length; i++)
            {

                temp = temp_string[i].ToCharArray();

                for(int j = 0; j<temp.Length; j++)
                {
                    if (j %  2 == 0)
                    {
                        temp[j] = Char.ToUpper(temp[j]);
                    }
                    else
                    {
                        temp[j] = Char.ToLower(temp[j]);
                    }

                }
                temp_string[i] = new string(temp);

            }

            answer = string.Join(" ", temp_string);
            return answer;
        }


    }
}
