using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("消息已存入数据库。。。");
        }
    }
}
