using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 选择题目
            /*
             下面哪个属性权限可以保证属性只能在类内部访问使用?
             A:public
             B:protect
             C:默认
             D:private
             */

            // 填空题目
            /*
             面向对象编程具有_____、_____、_____三大特点
             */

            // 初始化数据
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
          
            Application.Run(form);
        }

        private static ArrayList initData()
        {
            ArrayList list = new ArrayList();
            Choice c1 = new Choice("1. 下面哪个属性权限可以保证属性只能在类内部访问使用?", "A:public", "B:protect",
                "C:默认", "D:private", 4);
            list.Add(c1);
            Choice c2 = new Choice("2. 下面哪个属性权限可以保证属性只能在类内部访问使用?", "A:public", "B:protect",
               "C:默认", "D:private", 4);
            list.Add(c2);

            return list;
        }
    }
}
