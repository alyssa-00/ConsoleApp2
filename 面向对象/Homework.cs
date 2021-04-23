using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class Homework
    {
        /// <面向对象>作业二：构造函数/属性/索引器
        ///
        /// </summary>
        static void NameProperty()
        {
            //作业（二）：
            //1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
            //user.Password在类的外部只能改不能读
            //如果user.Name为“admin”，输入时修改为“系统管理员”
            //problem.Reward不能为负数

            User yezi = new User("yezi", "1234a");
            yezi.Password = "3456a";//可改
            //Console.WriteLine(yezi.Password);//不可读
            yezi.Name = "admin";//admin输入时不可以有空格
            Console.WriteLine(yezi.Name);
            Problem help = new Problem();//调用无参构造函数
            help.Reward = -2;
            Console.WriteLine(help.Reward);//如果输入负数,help.Reward=0

            //2、调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
            //在其他题目里都有调用
        }
        static void Indexer()
        {
            //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
            //分析：用户通过构造函数传入关键字，关键字个数不超过十个；//索引器，后台要记录用户的选择，存入keywords字段
            Article sos = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET" });
            //Article sos = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET", "1", "2", "3", "1", "4", "5" });//超过10个的，用于测试
            //for (int i = 0; i < sos.Keywords.Length; i++)
            //{
            //    Console.WriteLine(sos[i + 1]);
            //}
            Console.WriteLine(sos[5]);
        }
        static void Constructor()
        {
            //4、设计一种方式，保证：
            //每一个Problem对象一定有Body赋值//在构造函数里带一个body的参数
            //Problem sos = new Problem("今天天气很好。。。");
            //Console.WriteLine(sos.Body);

            //每一个User对象一定有Name和Password赋值//在构造函数里写
            //User yezi = new User("yezi", "1234a");
            //yezi.LogOn(out string output);
            //Console.WriteLine(output);
        }
        /// <面向对象>作业三:静态和实例
        /// 
        /// </summary>
        static void Repoistory()
        {
            //1、定义一个仓库（Repoistory）类，用于存取对象，其中包含：
            //一个int类型的常量version
            //一个静态只读的字符串connection，以后可用于连接数据库
            //思考Respoitory应该是static类还是实例类更好
            //详见（Repoistory）类
        }
        static void Problem()
        {
            //2、考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
            //Publish()：发布一篇求助，并将其保存到数据库
            //Load(int Id)：根据Id从数据库获取一条求助
            //Delete(int Id)：根据Id删除某个求助
            //repoistory：可用于在底层实现上述方法和数据库的连接操作等
            //详见problem类
        }
        static void QuestionAndAnswer()
        {
            //4、想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article)么？
            //答：
            //这涉及到编程里一个职责划分的问题，不同于现实世界中，人们所指的应该做某事、能做某事，是一种权限问题，但在程序里，是否应该做某事，是一个能力问题，
            //是否拥有做某件事的资源，据此判断，Publish（）方法所在的类（即Problem类），拥有了一篇文章发布所需满足的所有资源，比如：Body(正文)Title（标题）等，
            //所以不会放在User类，而是放在更适合的problem类里。
        }
        static void MimicStack()
        {
            //5、自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
            //1、出栈Pop()，弹出栈顶数据
            //2、入栈Push()，可以一次性压入多个数据
            //3、出 / 入栈检查，
            //（1）如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
            //（2）如果已弹出所有数据，提示“栈已空”
            //MimicStack mimic = new MimicStack(10);//从构造函数传入不同次数进行测试
            //Console.WriteLine(mimic.Check()); 

        }
        ///<面向对象>作业四:继承
        /// 
        /// </summary>
        static void Content()
        {
            //1、让User类无法被继承
            //sealed

            //2、观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
            //Content中有一个字段：kind，记录内容的种类（problem / article / suggest等），只能被子类使用
            //确保每个Content对象都有kind的非空值
            //Content con = new Content("Problem");
            //Console.WriteLine(con.Kind);
            //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
            //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
            ///详见Content类。

        }
        static void Call()
        {
            //3、实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法
            //Article art = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET" });
            //art.Kind = "编程";
            //Console.WriteLine($"现在的时间是：{art.PublishTime},发表的文章种类是{art.Kind},第一个关键字是：{art[1]}");
            //Suggest sug = new Suggest();
            //sug.Publish();

        }
        static void Entity()
        {
            //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
            //Suggest sug = new Suggest();
            //sug.Publish();
            //Console.WriteLine(sug.Id);
        }
        ///<面向对象>作业五:多态
        /// 
        /// </summary>
        static void Polymorphism()
        {
            //添加一个新类ContentService，其中有一个发布（Publish()）方法：
            //如果发布Article，需要消耗一个帮帮币
            //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
            //如果发布Suggest，不需要消耗帮帮币
            //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine()代替。根据我们学习的继承和多态知识，实现上述功能
            ///方法一：
            //cost(new Article(new string[] { "面向对象" }));
            //cost(new Problem { Reward = 20 });
            //cost(new Suggest());

            //static void cost(Content content)
            //{
            //    content.Publish();
            //}

            /////方法二：
            /////跟HelpMoney联系起来
            //HelpMoney hel = new HelpMoney();
            //Console.WriteLine(hel.MoneyChange(new Article(new string[] { "面向对象" })));
            //Console.WriteLine(hel.MoneyChange(new Problem { Reward = 20 }));
            //Console.WriteLine(hel.MoneyChange(new Suggest()));
        }













    }
}
