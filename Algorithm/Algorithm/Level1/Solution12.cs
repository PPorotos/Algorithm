using System;
using System.Text;

namespace Algorithm.Algorithm
{
    public class Solution12
    {
        //시저 암호
        public string solution(string s, int n)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var cha in s)
            {
                if(cha == ' ')
                {
                    sb.Append(cha);
                    continue;
                }
                int temp = cha;
                temp += n;
                if('a' <= cha && cha <= 'z')
                {
                    if(temp > 'z')
                    {
                        temp -= 26;
                    }
                }
                else
                {
                    if(temp > 'Z')
                    {
                        temp -= 26;
                    }
                }
                sb.Append((char)temp);

            }
            return sb.ToString();
        }

    }
}
