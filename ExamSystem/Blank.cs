using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    class Blank
    {
        public string questionDesc; // 题目描述内容
        public int blankNum; // 空格数量
        public string blankA; // 填空 A 的答案
        public string blankB; // 填空 B 的答案
        public string blankC; // 填空 C 的答案
        public string blankD; // 填空 D 的答案

        public Blank()
        {

        }

        public Blank(string questionDesc, int num, 
            string blankA, string blankB = "", string blankC = "", string blankD = "")
        {
            this.questionDesc = questionDesc;
            this.blankNum = num;
            this.blankA = blankA;
            this.blankB = blankB;
            this.blankC = blankC;
            this.blankD = blankD;
        }
    }
}
