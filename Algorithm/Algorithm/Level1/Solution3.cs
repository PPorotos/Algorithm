using System;
namespace Algorithm.Algorithm
{
    //핸드폰번호 가리기 
    public struct Solution3
    {
        public string solution(string phone_number)
        {
            string answer = "";

            char[] number = phone_number.ToCharArray();

            if(number.Length == 0)
            {
                return phone_number;
            }
            for (int i = 0; i < number.Length - 4; i++)
            {
                number[i] = '*';
            }

            answer = new string(number);

            return answer;
        }
    }
}
