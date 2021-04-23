using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class MimicStack
    {
        //5、自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
        //1、出栈Pop()，弹出栈顶数据
        //2、入栈Push()，可以一次性压入多个数据
        //3、出 / 入栈检查，
        //（1）如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
        //（2）如果已弹出所有数据，提示“栈已空”
        private int times;
        public int Times { get; set; }
        public MimicStack(int times)
        {
            Times = times;
        }
        public  static  int capacity =100;
        public int data;
        /// <summary>
        /// 弹出栈顶数据,一个一个弹出去
        /// </summary>
        public int Pop()
        {
            ///一个一个弹出
            //假设弹出的速度是放入的**倍
            ///while循环，在new的时候传终止循环的次数
            ///终止条件：栈已空的时候，停止弹出//在循环里调用check函数之后，会出现stackoverflow.
            int popnum = 0,i=0;
            while (i<Times)
            {
                i++;
                popnum++;
            }
            return popnum;
        }
        public int Push()//可以一次性压入多个数据
        {
            ///生成随机数
            Random ra = new Random();//生成随机数的方法
            int pushnum = 0,i=0;
            while (i < Times)
            {
                i++;
                pushnum = pushnum + ra.Next(1, 5);
            }
            return pushnum;
        }
        /// <summary>
        /// 出 / 入栈检查，
        /// </summary>
        public string Check()
        {
            string output="";
            int residual = Push()-Pop();
            if (residual > capacity)
            {
                output="栈溢出";
            }
            else if (residual == 0)
            {
                output = "栈已空";
            }//else nothing
            //else
            //{
            //    output = "栈未满";//用于测试
            //}
            return output;
        }










    }
}
