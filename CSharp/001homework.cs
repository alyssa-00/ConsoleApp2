using System;

namespace homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////1.输出两个整数 / 小数的和 / 差 / 积 / 商
            //float a1 = 3.3f;
            //float b1 = 3.4f;
            //Console.WriteLine(3 + 4);
            //Console.WriteLine(3 - 4);
            //Console.WriteLine(3 * 4);
            //Console.WriteLine(3 / 5);
            //Console.WriteLine(3 % 5);//取余
            //Console.WriteLine(a1 + b1);
            //Console.WriteLine(a1 - b1);
            //Console.WriteLine(a1 * b1);
            //Console.WriteLine(a1 / b1);

            //2.电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            ///////方法一：
            //float result = (float)((23 + 7) * 12 - 8) / 6;
            //string finalresult = result.ToString("#0.00");
            //Console.WriteLine(finalresult);
            /////方法二：
            //float result2 = (float)((23 + 7) * 12 - 8) / 6;
            //string finalresult2 = String.Format("{0:N2}", result2);
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


            ///////5.当a为何值时，结果为true？
            //int a = 12;
            //bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;//需要用到分支循环，元组，先看后面再回来改
            //Console.WriteLine(result);
            //////方法一：
            //////口算： 10，12





            //    作业
            //观察一起帮登录页面，用if...else ...完成以下功能。
            //用户依次由控制台输入：验证码、用户名和密码：
            //1.如果验证码输入错误，直接输出：“*验证码错误”；
            //2.如果用户名不存在，直接输出：“*用户名不存在”；
            //3.如果用户名或密码错误，输出：“*用户名或密码错误”
            //4.以上全部正确无误，输出：“恭喜！登录成功！”
            //PS：验证码 / 用户名 / 密码直接预设在源代码中，输入由Console.ReadLine()完成。



            //string origin_u = "yezi";
            //string origin_c = "1234a";
            //string origin_v = "345q";

            //string username = Console.ReadLine();
            //string code = Console.ReadLine();
            //string verification = Console.ReadLine();
            //string output;
            //if (origin_u == username && origin_c == code && origin_v == verification)
            //{
            //    output = "恭喜！登录成功!";
            //}
            //else
            //{
            //    if (origin_u != username)
            //    {
            //        output = "用户名不存在";
            //    }
            //    else if (origin_v != verification)
            //    {
            //        output = "验证码错误";
            //    }
            //    else
            //    {
            //        output = "用户名或密码错误";
            //    }
            //}
            //Console.WriteLine(output);




            ////数组
            //1.将源栈同学姓名 / 昵称分别：
            //o 按进栈时间装入一维数组，
            //o 按座位装入二维数组，
            //并输出共有多少名同学。

            //string[] march = { "周丁浩", "夏康平", "胡涛", "姜鹏", "韩佳宝", "刘圣灵" };
            //string[,] seats = { { "周丁浩", "夏康平" }, { "胡涛", "姜鹏" }, { "韩佳宝", "刘圣灵" } };
            //Console.WriteLine($"3月入栈的共{seats.Length}位");






            ////            作业：
            ////1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 1, 3, 5, 7, 9 };
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.WriteLine(array1[i]);
            //}
            //int j=0;
            //while (j < array2.Length)
            //{
            //    Console.WriteLine(array2[j]);
            //    j++;
            //}


            //2.用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            ///一维数组
            //string[] march = { "周丁浩", "夏康平", "胡涛", "姜鹏", "韩佳宝", "刘圣灵" };
            //for (int i = 0; i < march.Length; i++)
            //{
            //    Console.WriteLine(march[i]);
            //}

            ///二维数组
            //string[,] seats = { { "周丁浩", "夏康平" }, { "胡涛", "姜鹏" }, { "韩佳宝", "刘圣灵" } };
            //for (int i = 0; i < seats.Length / seats.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seats.GetLength(0); j++)
            //    {
            //        Console.WriteLine(seats[j, i]);//j代表一维度空间的长度
            //    }
            //}




            ////3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值//需要修改
            //int sum = 0;
            //int i = 1;
            //while (i < 101)
            //{
            //    sum += i;
            //    i = i + 2;
            //}
            //Console.WriteLine(sum);






            //////4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] scores = { 99, 85.5, 78, 83, 60, 88, 100 };
            //double max = scores[0];
            //double min = scores[0];
            //for (int i = 0; i < scores.Length - 1; i++)
            //{
            //    if ( scores[i + 1] > max)
            //    {
            //        max = scores[i + 1];
            //    }
            //    else if (scores[i + 1]<min)
            //    {
            //        min = scores[i + 1];
            //    }// else nothing
            //}
            //Console.WriteLine($"源栈{scores.Length}位同学里最高分为{ max}分！\r\n最低分为{ min}分。");



            //////5.找到100以内的所有质数（只能被1和它自己整除的数）
            ///////
            //for (int i = 2; i < 101; i++)//1是非质数，所以直接从2开始
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0 )
            //        {
            //            break;
            //        }
            //        else if (i == j + 1)
            //        {
            //            Console.WriteLine($"{i}是质数");
            //        }
            //    }
            //}



            /////6.生成一个元素（值随机）从小到大排列的数组
            ///
            //int[] array = new int[10];
            //Random ra = new Random();
            //array[0] = ra.Next(1, 90);
            //for (int k = 0; k < 9; k++)
            //{
            //    array[k + 1] = array[k] + ra.Next(1, 90);
            //}
            //Console.WriteLine("生成一个元素（值随机）从小到大排列的数组:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]},");
            //}


            ///7.设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()
            //int[,] mda = new int[3, 4];
            //int row = mda.Length / mda.GetLength(0);
            //Console.WriteLine("一个二维数组，元素值等于下标之和：");
            //for (int i = 0; i < mda.GetLength(0); i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write($"{i + j}\t");
            //    }
            //    Console.WriteLine();//换行
            //Environment.NewLine;
            //}





            ////二分查找
            //int input = 11;
            //int[] array = { 11, 12, 18, 25, 35, 47, 57, 69, 75, 83, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
            //int left = 0, right = array.Length - 1, mid;
            //while (left <= right)//用小于等于第0位的数去测试left=right;
            //{
            //    mid = (left + right) / 2;
            //    if (input < array[mid])
            //    {
            //        right = mid - 1;
            //    }
            //    else if (input > array[mid])
            //    {
            //        left = mid + 1;
            //    }
            //    else/*input == array[mid]*/
            //    {
            //        Console.WriteLine($"找到了!在数组中的第{mid + 1}位");
            //        break;
            //    }
            //}



            //        函数作业（一）
            //1、将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。


            //2、计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //////方法一,从控制台界面输入成绩

            //Console.WriteLine($"这届源栈同学的平均成绩是：{GetAverage()}");


            //3、完成“猜数字”游戏，方法名GuessMe()：
            //随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ
            //GuessMe();


            //        函数作业（二）


            ////作业
            ////1、利用ref调用Swap()方法交换两个同学的床位号
            //int ChouBedID = 3, HanBedID = 5;//choubedid = 3（周丁浩）hanbedid = 5（韩佳宝）
            //swap(ref ChouBedID, ref HanBedID);
            //Console.WriteLine($"\r\n交换之后周丁浩的床位号由3号变成：{ChouBedID}号\r\n\r\n韩佳宝的床位号由5号变成：{HanBedID}号");

            //2、将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            ////true / false，表示登陆是否成功
            ////string，表示登陆失败的原因
            //Console.WriteLine(LogOn(out bool success));
            //Console.WriteLine(success);


            //        函数作业（三）
            //作业
            //1、定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            //最小值min（默认为1）//
            //相邻两个元素之间的最大差值gap（默认为5）//如何使随机数间隔不超过5
            //元素个数length（默认为10个）
            //var arr = GetArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //2、实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //传入一个有序（从大到小/从小到大）数组和数组中要查找的元素//从大到小的怎么写
            //如果找到，返回该元素所在的下标；否则，返回-1
            //Console.WriteLine(BinarySeek(new int[] { 11, 12, 18, 25, 35, 47, 57, 69, 75, 83, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 10));






        }


        /// <summary>
        /// 求取平均值
        /// </summary>
        /// <returns>平均值</returns>
        static string GetAverage()
        {
            int round = 0;//默认值是四舍五入
            Double sum = 0, temp = 0;
            Console.WriteLine("请输入个数：");
            int num = (Convert.ToInt32(Console.ReadLine()));
            Double[] array = new Double[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"请输入值,还差{num - i}位");
                array[i] = (float)Convert.ToSingle(Console.ReadLine()) * 100 * 1.0 / 100;
                sum = sum + array[i];
            }
            temp = sum / array.Length;
            //Console.WriteLine(temp);
            ///方法一：四舍五入
            Console.WriteLine("四舍五入请按0，直接保留小数点后两位请按1");
            if (round == Convert.ToInt32(Console.ReadLine()))
            {
                string average = temp.ToString("#0.00 ");
                return (average);
            }
            /////方法二：直接保留小数点后两位
            else
            {
                var tempo = (int)(temp * 100) / 100.00;
                string average = tempo.ToString();
                return (average);
            }
        }
        /// <summary>
        /// 猜数字游戏
        /// </summary>
        /// <returns>void</returns>
        static void GuessMe()
        {
            Console.WriteLine("请输入一个不超过1000的自然数：");
            int test = new Random().Next(1, 1000);
            string output;
            for (int i = 1; i < 11; i++)//最好用while,截断式编程
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if ((test != input))//可以加一个输入的式超出规定范围数字的条件，防御式编程
                {
                    if (i == 10)
                    {
                        output = ("(～￣(OO)￣)ブ");
                    }
                    else if (test > input)
                    {
                        output = ($"太小了哟，还剩{10 - i}次");
                    }
                    else
                    {
                        output = ($"太大了哟，还剩{10 - i}次");
                    }
                }
                else//test ==input
                {
                    if (i <= 5)
                    {
                        output = ("你真牛逼！");
                        break;
                    }
                    else
                    {
                        output = ("不错嘛！");
                        break;
                    }
                }
                Console.WriteLine(output);
            }


        }
        /// <summary>
        /// 交换两个变量的值
        /// </summary>
        /// <param name="a">任意整数</param>
        /// <param name="b">任意整数</param>
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="success"true表示成功，false表示失败></param>
        /// <returns>string，错误提示</returns>
        static string LogOn(out bool success)//最好用bool值作为返回值
        {
            Console.WriteLine("请依次输入：用户名、密码和验证码");
            string origin_u = "yezi";
            string origin_c = "1234a";
            string origin_v = "345q";


            string username = Console.ReadLine();
            string code = Console.ReadLine();
            string verification = Console.ReadLine();
            string output;

            success = false;
            if (origin_u == username && origin_c == code && origin_v == verification)
            {
                output = "恭喜！登录成功!";
                success = true;
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
            return output;

        }
        /// <summary>
        /// 随机生成从小到大排列的数组
        /// </summary>
        /// <param name="min">数组的最小值</param>
        /// <param name="gap">相邻两个元素间隔</param>
        /// <param name="length">元素个数</param>
        static int [] GetArray(int min = 1, int gap = 5, int length = 10)
        {
            int[] array;
            array = new int[length];
            Random ra = new Random();//生成随机数的方法
            for (int i = 0; i < length; i++)
            {
                array[i] = min;
                min = min + ra.Next(1, gap);
                //Console.WriteLine(array[i]);
            }
            return array;
        }
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="numbers">有序数组</param>
        /// <param name="target">要查找的对象，整数</param>
        /// <returns>如果找到，返回该元素所在的下标；否则，返回-1</returns>
        static int BinarySeek(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1, mid;
            while (left <= right)//用小于等于第0位的数去测试left=right;
            {
                mid = (left + right) / 2;
                if (target < numbers[mid])
                {
                    right = mid - 1;
                }
                else if (target > numbers[mid])
                {
                    left = mid + 1;
                }
                else/*input == array[mid]*/
                {
                    //Console.WriteLine($"找到了!在数组中的第{mid + 1}位");
                    return mid + 1;
                    
                }
            }
            return -1;
        }








    }



}