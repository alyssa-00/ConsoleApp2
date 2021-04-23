using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class Suggest:Content
    {
        public Suggest() : base("Suggest")
        {
            
        }
        public override int Publish()
        {
            int cost = 0;
            Console.WriteLine($"本次发布需要消耗帮帮币：{cost}个");
            return cost;

        }



    }
}
