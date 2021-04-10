using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.输出两个整数 / 小数的和 / 差 / 积 / 商
            float a1 = 3.3f;
            float b1 = 3.4f;
            Console.WriteLine(3 + 4);
            Console.WriteLine(3 - 4);
            Console.WriteLine(3 * 4);
            Console.WriteLine(3 / 5);
            Console.WriteLine(3 % 5);//取余
            Console.WriteLine(a1 + b1);
            Console.WriteLine(a1 - b1);
            Console.WriteLine(a1 * b1);
            Console.WriteLine(a1 / b1);

            //2.电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            /////方法一：
            //float result = (float)((23 + 7) * 12 - 8) / 6;
            //string finalresult = result.ToString("#0.00");
            //Console.WriteLine(finalresult);
            /////方法二：
            //float result2 = (float)((23 + 7) * 12 - 8) / 6;
            //string finalresult2 = String.Format("{0:N2}",result2);
            //Console.WriteLine(finalresult);

            ////3.想一想以下语句输出的结果
            //int i = 15;
            //Console.WriteLine(i++);//15//这是一个特殊情况,本来应该是16，改成++i结果就正常了
            //i -= 5;
            //Console.WriteLine(i);//11
            //Console.WriteLine(i >= 10);//True
            //Console.WriteLine("i值的最终结果为：" + i);//i值的最终结果为：11
            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");//11+20=31


            ///4.想一想如下代码的结果是什么，并说明原因：
            //int a = 10;
            //Console.WriteLine(a > 9 && (!(a < 11) || a > 10));//False,因为True&&(!(True||False))=True&&(!(True))=True&&False=False


            /////5.当a为何值时，结果为true？
            int a = 12;
            bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;//需要用到分支循环，元组，先看后面再回来改
            Console.WriteLine(result);
            ////方法一：
            ////口算： 10，12





            //    作业
            //观察一起帮登录页面，用if...else ...完成以下功能。
            //用户依次由控制台输入：验证码、用户名和密码：
            //1.如果验证码输入错误，直接输出：“*验证码错误”；
            //2.如果用户名不存在，直接输出：“*用户名不存在”；
            //3.如果用户名或密码错误，输出：“*用户名或密码错误”
            //4.以上全部正确无误，输出：“恭喜！登录成功！”
            //PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。



            string origin_u = "yezi";
            string origin_c = "1234a";
            string origin_v = "345q";

            string username = Console.ReadLine();
            string code = Console.ReadLine();
            string verification = Console.ReadLine();
            string output;
            if (origin_u == username && origin_c == code && origin_v == verification)
            {
                output = "恭喜！登录成功!";
            }
            else
            {
                if (origin_u != username)
                {
                    output = "用户名不存在";
                }
                else if (origin_v != verification)
                {
                    output = "验证码错误";
                }
                else
                {
                    output = "用户名或密码错误";
                }

            }

            Console.WriteLine(output);

























        }



    }

}