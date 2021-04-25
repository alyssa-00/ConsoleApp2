using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("消息发送成功！");
        }
    }
}
