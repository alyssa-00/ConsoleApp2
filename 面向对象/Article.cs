using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    public class Article : Content 
    {
        ///作业（二）
        //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        private string title;
        public string Title { get; set; }
        public Article(string[] keywords) : base("Article")//有参构造函数
        {
            if (keywords.Length > 10)
            {
                Console.WriteLine("关键字最多不超过10个哦");
            }
            else
            {
                this.Keywords = keywords;
            }
        }
        private User author;//Author=new User();
        //public User Author { get; set; }
        //public User Voter { get; set; }
        private string[] keywords;
        public string[] Keywords { get; set; }
        public string this[int index]//索引器
        {
            get { return Keywords[index - 1]; }//取
            set { Keywords[index - 1] = value; }//传
        }

        public override void Release()
        {
            Author.HelpPoint--;
            Console.WriteLine($"本次发布需要消耗1个帮帮币");
        }
        public bool Rewarded()
        {
            bool Rewarded = false;
            if (Rewarded)
            {
                //return true;
            }//else nothing
            return Rewarded;
        }

        public override void Comment()
        {
            Console.WriteLine("我有评论：");
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
