using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    class Choice
    {
        public string questionDes; // 题目描述内容
        public string optionA; // 选项 A 的内容
        public string optionB; // 选项 B 的内容
        public string optionC; // 选项 C 的内容
        public string optionD; // 选项 D 的内容
        public int answer; // 正确答案

        public Choice()
        {

        }
        public Choice(string questionDes, 
            string optionA, string optionB, string optionC, string optionD, int answer)
        {
            this.questionDes = questionDes;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.answer = answer;
        }
    }
}
