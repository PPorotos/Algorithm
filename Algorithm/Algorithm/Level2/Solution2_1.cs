using System;
using System.Collections.Generic;

namespace Algorithm.Algorithm.Level2
{
    //스킬트리
    public class Solution2_1
    {
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;
            List<char> skillCheck = new List<char>(skill.ToCharArray());
            bool countTrue = true;

            for(int i = 0; i<skill_trees.Length; i++)
            {
                List<char> skilltree = new List<char>(skill_trees[i].ToCharArray());
                bool[] skillTrueCheck = new bool[skill.Length];
                for (int j = 0; j < skilltree.Count; j++)
                {
                    if (!skillCheck.Contains(skilltree[j]))
                    {
                        continue;
                    }
                    else
                    {
                        for(int k = 0; k<skillCheck.Count; k++)
                        {
                            if(k==0 && skilltree[j] == skillCheck[k])
                            {
                                skillTrueCheck[k] = true;
                                break;
                            }else if(skilltree[j]==skillCheck[k]){
                                if(skillTrueCheck[k-1])
                                {
                                    skillTrueCheck[k] = true;
                                    break;
                                }
                                else
                                {
                                    countTrue = false;
                                    break;
                                }
                            }
                        }
                        if (!countTrue)
                        {
                            break;
                        }
                    }
                }
                if (countTrue)
                {
                    answer += 1;
                }
                else
                {
                    countTrue = true;
                }
            }
            return answer;
        }

     
    }

}
