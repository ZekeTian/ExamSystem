using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class Form1 : Form
    {
        private const int choiceScore = 5;
        private const int blankScore = 5;
        private const string dirPath = @"C:\javaexam1\"; // 存储结果的目录路径
        private const string fileName = "score.txt"; // 存储结果的目录文件名
        private ArrayList choiceList; // 选择题题目集合
        private ArrayList blankList; // 填空填题目集合
        private int[] choiceAnswer; // 记录用户选择题答案
        private string[,] blankAnswer; // 记录用户的填空题答案
        private int totalScore = 0;
        private int curNum; // 当前正在做的题目序号
        private int choiceAmount;
        private int blankAmount;
        private List<Button> buttonList; // 右侧题目按钮列表
        private List<TextBox> textList; // 填空题的输入框
        private RadioButton curOption; // 用户选择的选项, 便于在选择下一道题时将其选择的状态清除

        public Form1()
        {
            InitializeComponent();
        }

        public void setData(ArrayList choices, ArrayList blanks)
        {
            choiceList = choices;
            choiceAmount = choices.Count;
            blankList = blanks;
            blankAmount = blanks.Count;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 读取选择题
            readChoiceData();

            //    string examContent = reader.ReadToEnd();              
            /*
                Choice c1 = new Choice("1. 下面哪个属性权限可以保证属性只能在类内部访问使用?", "A:public", "B:protect",
                    "C:默认", "D:private", 4);
                choiceList.Add(c1);
                Choice c2 = new Choice("2. java 里面判断两个对象是否相等的方法?", "A:==", "B:compare()",
                   "C:equals()", "D:toString()", 3);
                choiceList.Add(c2);
                Choice c3 = new Choice("3. 构造方法何时调用?", "A:类定义时", "B:创建对象时",
                  "C:访问类的成员变量时", "D:调用类的方法时", 2);
                choiceList.Add(c3);
                Choice c4 = new Choice("4. 下面哪个不是java的特点?", "A:跨平台", "B:编译型语言",
                  "C:面向对象", "D:能够自动进行垃圾回收", 2);
                choiceList.Add(c4);
                choiceAmount = choiceList.Count;
            */
            // 读取填空题

            readBlankData();

            /*
            blankList = new ArrayList();
            Blank b1 = new Blank("5. 面向对象编程具有_____、_____、_____三大特点", 3, "封装", "继承", "多态");
            blankList.Add(b1);

            Blank b2 = new Blank("6. java 的数据类型可以分为_____、_____两大基本类型", 2, "基本类型", "引用类型");
            blankList.Add(b2);
            blankAmount = blankList.Count;
            */

            choiceAnswer = new int[25];
            blankAnswer = new string[10,4];
            showChoice();

            buttonList = new List<Button>();
            for (int i = 0; i < choiceAmount + blankAmount; ++i)
            {
                Button btn = new Button();
               // btn.BackColor = Color.FromName("#FF5D5D");
                btn.BackColor = Color.Red;
                btn.Text = (i + 1) + "";
                btn.Font = new Font(Font.FontFamily, 10);
                btn.Click += MyButtonClick;
                tableQuestions.Controls.Add(btn);
                buttonList.Add(btn);
            }

            textList = new List<TextBox>();
            textList.Add(textBlank1);
            textList.Add(textBlank2);
            textList.Add(textBlank3);
            textList.Add(textBlank4);
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // 获取用户点击的题目标号
            curNum = Convert.ToInt32(button.Text) - 1;

            // 判断做的题目类型
            if (curNum <= choiceAmount - 1)
            {
                showChoice(); // 当前做的题目为选择题
            }
            else
            {
                showBlank(); // 当前做的题目为填空题
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void rbA_CheckedChanged_1(object sender, EventArgs e)
        { 
            // 监听的是 RadioButton 的选中变化事件, 选中和取消选中都会触发
            if (rbA.Checked)
            {
                setChoiceResult(1);
                curOption = rbA;
            }
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbB.Checked)
            {
                setChoiceResult(2);
                curOption = rbB;
            }
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbC.Checked)
            {
                setChoiceResult(3);
                curOption = rbC;
            }
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbD.Checked)
            {
                setChoiceResult(4);
                curOption = rbD;
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            // 判断是否到达第一道题
            if (curNum == 0)
            {
               return;
            }

            // 判断做的题目类型
            if (--curNum <= choiceAmount - 1)
            {
                showChoice(); // 当前做的题目为选择题
            }
            else
            {
                showBlank(); // 当前做的题目为填空题
            }
        }

        private void btnNext_Click_2(object sender, EventArgs e)
        {
            // 判断是否到达最后一道题
            if (curNum == (choiceAmount + blankAmount - 1))
            {
                MessageBox.Show("这是最后一道题目了");

                return;
            }

            // 判断做的题目类型
            if (++curNum <= choiceAmount - 1)
            {
                showChoice(); // 当前做的题目为选择题
            } else
            {
                showBlank(); // 当前做的题目为填空题
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 判断是否已经提交过
            if (System.IO.File.Exists(dirPath + fileName))
            {
                MessageBox.Show("已经提交答案，不能再次提交!");

                return;
            }

            // 计算成绩
            totalScore = 0;
            // 遍历用户选择题答案
            for (int i = 0; i < choiceAmount; ++i)
            {
                if (choiceAnswer[i] == ((Choice)choiceList[i]).answer)
                {
                    totalScore += choiceScore;
                }
            }

            // 遍历填空题进行比较
            for (int i = 0; i < blankAmount; ++i) // 遍历每道填空题
            {
               Blank b = (Blank)blankList[i];
               for (int j = 0; j < b.blankNum; ++j) // 遍历用户第 i 题的回答的答案(不分顺序)
               {
                    string userAnswer = blankAnswer[i, j]; // 用户回答的答案

                    // 不分顺序, 则判断用户回答的答案是否在正确答案中
                    if ("" != userAnswer && null != userAnswer) // 判断用户是否回答该问题
                    {
                        // 用户回答了该问题, 则判断是否在正确答案中
                        userAnswer = userAnswer.Trim();
                        if (userAnswer == b.blankA)
                        {
                            totalScore += blankScore;
                        } else if (userAnswer == b.blankB)
                        {
                            totalScore += blankScore;
                        } else if (userAnswer == b.blankC)
                        {
                            totalScore += blankScore;
                        } else if (userAnswer == b.blankD)
                        {
                            totalScore += blankScore;
                        }
                    }
               }
            }

            string score = "最终成绩为: " + totalScore;
            MessageBox.Show(score); // 对话框显示
            scoreLabel.Text = "成绩:" + totalScore;

            // 判断是否有该目录, 如果没有该目录, 则创建目录
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath);
            }
            File.WriteAllText(dirPath + fileName, score);


            // MessageBox.Show("textBlank1.Text is: " + textBlank1.Text + ",textBlank1.Text == \"\"" + (textBlank1.Text == ""));
        }

        private void btnNotDone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // 当 TextBox 失去焦点时即认为其输入完毕, 则记录其答案
        private void textBlank1_Leave(object sender, EventArgs e)
        {
            setBlankResult(0, textBlank1.Text);
        } 

        private void textBlank2_Leave(object sender, EventArgs e)
        {
            setBlankResult(1, textBlank2.Text);
        }

        private void textBlank3_Leave(object sender, EventArgs e)
        {
            setBlankResult(2, textBlank3.Text);
        }

        private void textBlank4_Leave(object sender, EventArgs e)
        {
            setBlankResult(3, textBlank4.Text);
        }

        private void showChoice()
        {
            if (null != curOption)
            {
                // curOption.Checked = false;
            }

            choicePanel.BringToFront();

            Choice c = (Choice)choiceList[curNum];
            choiceQuestion.Text = c.questionDes;
            rbA.Text = c.optionA;
            rbB.Text = c.optionB;
            rbC.Text = c.optionC;
            rbD.Text = c.optionD;

            // 检查该选择题是否做过, 如果已经做过, 则显示勾选的答案
            switch(choiceAnswer[curNum])
            {
                case 1:
                    rbA.Checked = true;
                    break;
                case 2:
                    rbB.Checked = true;
                    break;
                case 3:
                    rbC.Checked = true;
                    break;
                case 4:
                    rbD.Checked = true;
                    break;
                default: // choiceResult 数组中元素默认为 0, 即没有做过该选择题, 则所有选项的选择状态全部清除
                    rbA.Checked = false;
                    rbB.Checked = false;
                    rbC.Checked = false;
                    rbD.Checked = false;
                    break;
            }
        }
        private void showBlank()
        {
            blankPanel.BringToFront();
            Blank b = (Blank)blankList[curNum - choiceAmount];
            blankQuestion.Text = b.questionDesc;

            // 根据填空题的空格数量来显示输入框
            int size = textList.Count;
            for (int i = 0; i < b.blankNum; ++i) // 需要显示的输入框, 则清空之前输入的数据
            {
                textList[i].Visible = true; // 显示
                textList[i].Text = null == blankAnswer[curNum - choiceAmount, i] ?
                "" : blankAnswer[curNum - choiceAmount, i].ToString(); // 清空之前的数据
            }

            // 隐藏多余的输入框
            for (int i = b.blankNum; i < size; ++i)
            {
                textList[i].Visible = false; // 隐藏多余的输入框
            }
        }

        /*
         * 记录用户选择题的答案
         */
            private void setChoiceResult(int result)
        {          
            choiceAnswer[curNum] = result;

            buttonList[curNum].BackColor = Color.White;
        }

        /*
         * 记录用户填空题的答案
         * num 为题目第 num 个空, answer 为用户输入的答案
         */
        private void setBlankResult(int num, string answer)
        {
            blankAnswer[curNum - choiceAmount, num] = answer;

            if ("" != answer) // 如果没有真正回答问题, 则不改变颜色
            {
                buttonList[curNum].BackColor = Color.White;
            }
        }

        private void readChoiceData()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("ExamSystem.resource.choice.txt");
            StreamReader reader = new StreamReader(stream);

            string line = null;
            int count = 0;
            Choice c = new Choice();
            choiceList = new ArrayList();

            // 逐行读取题目文件
            while ((line = reader.ReadLine()) != null)
            {
                ++count;
                switch (count)
                {
                    case 1: // 题目
                        c.questionDes = line;
                        break;
                    case 2: // 选项 A
                        c.optionA = line;
                        break;
                    case 3: // 选项 B
                        c.optionB = line;
                        break;
                    case 4: // 选项 C
                        c.optionC = line;
                        break;
                    case 5: // 选项 D
                        c.optionD = line;
                        break;
                    case 6: // 答案
                        c.answer = Convert.ToInt32(line);
                        break;
                    default:
                        break;
                }

                if ("" == line || "end" == line) // line 为 end 时, 是最后一道题, 则也需要添加进去
                {
                    count = 0;
                    choiceList.Add(c); // 添加到集合中
                    c = new Choice();
                }

            }
            choiceAmount = choiceList.Count;
            reader.Close();
        }

        private void readBlankData()
        {
            // 读取 blank.txt 嵌入资源文件
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream stream = asm.GetManifestResourceStream("ExamSystem.resource.blank.txt");
            StreamReader reader = new StreamReader(stream);

            String line = null;
            Blank b = new Blank();
            int count = 0;

            blankList = new ArrayList();
            while ((line = reader.ReadLine()) != null)
            {
                ++count;
                switch(count)
                {
                    case 1:
                        b.questionDesc = line;
                        break;
                    case 2:
                        b.blankNum = Convert.ToInt32(line);
                        break;
                    case 3:
                        string[] blanks = line.Split(','); // 分割得到答案
                        b.blankA = blanks[0];

                        // 赋值给答案
                        if (blanks.Length >= 2)
                        {
                            b.blankB = blanks[1];
                        }

                        if (blanks.Length >= 3)
                        {
                            b.blankC = blanks[2];
                        }

                        if (blanks.Length == 4)
                        {
                            b.blankD = blanks[3];
                        }
                        break;
                    default:
                        break;
                }

                if ("" == line || "end" == line)
                {
                    count = 0;
                    blankList.Add(b);
                    b = new Blank();
                }
            }

            blankAmount = blankList.Count;
            reader.Close();
        }
    }
}
