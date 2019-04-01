using System;
using System.Text;

namespace Algorithm.Algorithm
{
    public class Solution11_1
    {
        //이상한 문자 만들기
        public string solution(string s)
        {
            StringBuilder sb = new StringBuilder();

            bool isUpper = true;

            foreach(var cha in s)
            {
                if(' ' == cha)
                {
                    sb.Append(cha);
                    isUpper = true;
                    continue;
                }

                sb.Append(isUpper ? Char.ToUpper(cha) : Char.ToLower(cha));
                isUpper = !isUpper;

            }
            return sb.ToString();
        }

    }
}
