using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    public class Problem: Content
    {
        public Problem() : base("Problem")  //无参构造函数  
        {

        }
        ///作业（一）
        ////*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        ///
        private  string Title;
        private string body;
        public string Body { get; set; }
        private int _reward;//字段
        //problem.Reward不能为负数
        public int Reward
        {
            get => _reward;
            set
            {
                if (value < 0)
                {
                    _reward = 0;
                    Console.WriteLine("悬赏币不能为负哦~");
                }
                else
                {
                    _reward = value;
                }

            }

        }//属性
        //private readonly  string publishdatetime;//父类Content已经有这个字段
        private User author;
        //public User Author { get; set; }
        //public User Voter { get; set; }
        ///作业（二）
        //4、设计一种方式，保证：
        //每一个Problem对象一定有Body赋值
        public Problem(string body): base("Problem")
        {
            this.Body = body;
        }
        ///作业（三）
        //2、考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int Id)：根据Id从数据库获取一条求助
        //Delete(int Id)：根据Id删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        public Problem Load(Problem problem)//适用于对象，每个problem对象都可以去数据库拿数据
        {
            //根据Id从数据库获取一条求助
            repoistory.Get(problem);
            return problem;
        }
        //public Problem Delete(Problem problem)
        //{
        //    //根据Id删除某个求助
        //    problem.Id = default;//因为是只读
        //    return problem;
        //}
        Repoistory repoistory = new Repoistory();
        
        public override void  Release()
        {
            Author.HelpPoint -= Reward;
            Console.WriteLine($"本次发布需要帮帮币的数量：{Reward}个");
        }

        public override void Comment()
        {
            Console.WriteLine("评论");
        }

        public override void Disagree()
        {
            base.Disagree();
            //可以用base.方法名（）的方式调用父类的方法(void可以,有返回值的时候好像不行)
        }

        public override void Agree()
        {
            base.Agree();
        }







    }
}
