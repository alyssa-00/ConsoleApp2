using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    public abstract class Content : Entity
    {
        //作业（四）
        //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
        //Content中有一个字段：kind，记录内容的种类（problem / article / suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        protected string kind;
        public string Kind { get; set; }
        public Content(string kind)
        {
            this.Kind = kind;
        }

        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        private string publishtime;
        public string PublishTime
        {
            get { return CreateTime(); }
        }
        private string CreateTime()
        {
            return "系统时间";
        }

        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        public abstract void Release();
        public abstract void Comment();
        //作业(六)接口：
        //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，
        //赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        ///
        public User Author { get; set; }
        public User Voter { get; set; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
        public virtual void Disagree()
        {
            Author.HelpPoint++;
            Voter.HelpPoint++;
            AgreeAmount++;
            Console.WriteLine($"{ Author.HelpPoint}\r\n{Voter.HelpPoint}\r\n{AgreeAmount}");
        }
        public virtual void Agree()
        {
            Author.HelpPoint++;
            Voter.HelpPoint++;
            AgreeAmount++;
            Console.WriteLine($"{ Author.HelpPoint}\r\n{Voter.HelpPoint}\r\n{AgreeAmount}");
        }


        
        


       












    }
}
