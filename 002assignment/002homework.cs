using System;

namespace _002assignment
{
    class Program
    {
        static void Main(string[] args)
        {
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
                else if (origin_v !=verification)
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
