using System;

namespace Add_a_new_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "冉家志", description = "是个笨蛋";
            //Console.WriteLine(name + description + "!");//字符串的拼接
            //Console.WriteLine($"今天路上有个小朋友说：{name }{description }!");//字符串的内插，{}相当于占位符；推荐这种方法

            ////Console.WriteLine(15 + "17");//+既可以用于运算，也可以用于字符串的拼接，所以此处涉及运算符重载的问题


            //string name = "冉家志", description = "是个笨蛋";
            //Console.WriteLine($"今天路上有个小朋友说：\"{name }{description }\"!");
            ///转义字符“\”在引号之前 
            ///书写需要输出的引号时也应该在英文模式下

            //string name = "冉家志", description = "是个笨蛋";
            //Console.WriteLine($"今天路上有个小朋友说：\\\\{name }{description }\\\\!");
            //Console.WriteLine($@"今天路上有个小朋友说：


            //{name }{description }!");//@去转义，还可以直接换行


            ///判断一个数是正数还是负数
            //Console.WriteLine("请任意输入一个整数");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////string output;//用output重构
            //////if (input > 0)
            //////{
            //////    output = "正数";
            //////}
            //////else
            //////{
            //////    output = "负数";
            //////}
            //string output = input > 0 ? "正数" : "负数";//条件选择符
            //Console.WriteLine(output);


            //Console.WriteLine("请输入成绩：");
            //float score = float.Parse(Console.ReadLine());
            //string output=score>=60?"及格":"不及格";
            //Console.WriteLine(output);


            //console.writeline("请输入成绩：");
            //int score = int.parse(console.readline());
            //string output;
            //if ((score > 100 || score < 0))
            //{
            //    output = "宝贝输错了哦~";
            //}
            //else
            //{
            //    if (score >= 60 && score <= 79)
            //    {
            //        output = "还可以哟~";
            //    }
            //    else if (score >= 80)
            //    {
            //        output = "真棒!!";
            //    }

            //    else if (score < 60 && score >= 30)
            //    {
            //        output = "还有救";
            //    }
            //    else
            //    {
            //        output = "学渣本渣了";
            //    }
            //}

            //console.writeline(output);


            ////数组
            //string[] names;
            ////names = new string[5];//new一块空间出来（地址）放到变量这个容器里面
            //names = new string[] { "老", "狼", "几", "点", "了", "!" };
            //Console.WriteLine(names[0]);

            //int[] boxes;
            //boxes = new int[3];
            //boxes[0] = 50;
            //Console.WriteLine(boxes[1]);//默认值为0
            //Console.WriteLine(boxes[2]);//默认值为0




            //            作业：
            //1.将源栈同学姓名 / 昵称分别：
            //o 按进栈时间装入一维数组，
            //o 按座位装入二维数组，
            //并输出共有多少名同学。


            //string[] march;
            //march = new string[] { "师兄1号", "师兄2号", "师兄3号" };
            //Console.WriteLine($"3月入栈:\r\n{march[0]}\r\n{march[1]}\r\n{march[2]}");


            ////将元组里的内容依次取出来
            ///


            string[] march;
            march = new string[] { "师兄1号", "师兄2号", "师兄3号" };
            int i = 0;
            while (i<3)
            {
                string output = march[i];
                i++;
                Console.WriteLine(output);
            }
            
            






        }
    }
}
