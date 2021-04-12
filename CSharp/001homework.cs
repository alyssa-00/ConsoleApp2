using System;

namespace test1
{
    class Program
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

            //for (int i = 0; i < seats.Rank; i++)
            //{
            //    for (int j = 0; j < seats.GetLength(0); j++)
            //    {
            //        Console.WriteLine(seats[j, i]);//j代表一维度空间的长度
            //}




            ////3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //int i = 1;
            //while (i < 99)
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
            //    if (max < scores[i + 1])
            //    {
            //        max = scores[i + 1];
            //    }
            //    else
            //    {
            //        if (min > scores[i + 1])
            //        {
            //            min = scores[i + 1];
            //        }// else nothing
            //    }
            //}
            //Console.WriteLine($"源栈{scores.Length}位同学里最高分为{ max}分！\r\n最低分为{ min}分。");



            //////5.找到100以内的所有质数（只能被1和它自己整除的数）
            ///////
            //int count = 0, sum = 0;
            //for (int i = 2; i < 101; i++)//1是非质数，所以直接从2开始
            //{
            //    for (int j = 2; j < 101; j++)
            //    {
            //        if (i % j == 0 && i != 1 && i != j)
            //        {
            //            //Console.WriteLine($"{i}是非质数");
            //            count = 0;//清空非质数在质数分支里的计数
            //            break;
            //        }
            //        else
            //        {
            //            if (count++ == i - 1)//count++;用于计算单个元素进来了多少次
            //            {
            //                sum = sum + 1;
            //                Console.WriteLine($"{i}是质数,共{ sum}个");
            //                count = 0;
            //                break;
            //            }//else nothing
            //        }
            //    }
            //}



            ///6.生成一个元素（值随机）从小到大排列的数组
            ///冒泡排序
            //int[] array = { 32, 45, 34, 22, 4, 45, 33, 55, 66, 98 };
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = 0; j < array.Length - 1 - i; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }/*else nothing*/
            //    }
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
            //}





            //////二分法查找
            /////从一组有序数列，查找是否有某个数
            ///
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"猜猜看这里面都有哪些数字，还有{10 - i}次机会哦~");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    int[] array = { 11, 12, 18, 25, 35, 47, 57, 69, 75, 83, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
            //    int left = 0, right = array.Length - 1, mid;
            //    while (left < right)
            //    {
            //        mid = (left + right) / 2;
            //        if (input < array[mid])
            //        {
            //            right = mid;
            //            if (mid == 0)
            //            {
            //                Console.WriteLine("没有找到这个数");
            //            }/*else nothing*/
            //        }
            //        else if (input > array[mid])
            //        {
            //            left = mid;
            //            if ((right - left) == 1 && input != array[right])
            //            {
            //                Console.WriteLine("没有找到这个数");
            //                break;
            //            }
            //            else if (input == array[right])
            //            {
            //                Console.WriteLine($"找到了!在数组中的第{right + 1}位");
            //                break;
            //            }/*else nothing*/
            //        }
            //        else/*input == array[mid]*/
            //        {
            //            Console.WriteLine($"找到了!在数组中的第{mid + 1}位");
            //            break;
            //        }
            //    }
            //}






















        }



    }

}