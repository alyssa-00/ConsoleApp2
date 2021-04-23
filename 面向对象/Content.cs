using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    public class Content:Entity
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


        public virtual int Publish()
        {
            Console.WriteLine("");
            Console.WriteLine($"文章提交成功!帮帮币结算：");
            int cost = 0;
            return cost;
        }
 
     
       









    }
}
