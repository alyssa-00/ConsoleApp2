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

        public override void Comment()
        {
            Console.WriteLine("评论：");
        }
        public override void Release()
        {
            Console.WriteLine($"本次发布不需要消耗帮帮币");
        }
        public override void Disagree()
        {
            base.Disagree();
        }

        public override void Agree()
        {
            base.Agree();
        }


    }




}
