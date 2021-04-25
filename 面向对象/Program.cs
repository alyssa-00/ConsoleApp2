using System;


namespace 面向对象
{
    class Program
    {

        static void Main(string[] args)
        {
            ///**************************************************************************************************************************************///
            //作业（二）：
            //1、将之前User/Problem/HelpMoney类的字段封装成属性，其中：
            //user.Password在类的外部只能改不能读
            //如果user.Name为“admin”，输入时修改为“系统管理员”
            //problem.Reward不能为负数

            //User yezi = new User("yezi", "1234a");
            //yezi.Password="3456a";//可改
            ////Console.WriteLine(yezi.Password);//不可读
            //yezi.Name = "admin";//admin输入时不可以有空格
            //Console.WriteLine(yezi.Name);
            //Problem help = new Problem();//调用无参构造函数
            //help.Reward = -2;
            //Console.WriteLine(help.Reward);//如果输入负数,help.Reward=0



            //2、调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
            //在其他题目里都有调用



            //3、一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
            //分析：用户通过构造函数传入关键字，关键字个数不超过十个；//索引器，后台要记录用户的选择，存入keywords字段
            //Article sos = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET" });
            ////Article sos = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET", "1", "2", "3", "1", "4", "5" });//超过10个的，用于测试
            ////for (int i = 0; i < sos.Keywords.Length; i++)//测试用
            ////{
            ////    Console.WriteLine(sos[i + 1]);
            ////}
            //Console.WriteLine(sos[5]);


            //4、设计一种方式，保证：
            //每一个Problem对象一定有Body赋值//在构造函数里带一个body的参数
            //Problem sos = new Problem("今天天气很好。。。");
            //Console.WriteLine(sos.Body);

            //每一个User对象一定有Name和Password赋值//在构造函数里写
            //User yezi = new User("yezi", "1234a");
            //yezi.LogOn(out string output);
            //Console.WriteLine(output);


            ///**************************************************************************************************************************************///


            //作业（三）：
            //1、定义一个仓库（Repoistory）类，用于存取对象，其中包含：
            //一个int类型的常量version
            //一个静态只读的字符串connection，以后可用于连接数据库
            //思考Respoitory应该是static类还是实例类更好
            //详见（Repoistory）类

            //2、考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
            //Publish()：发布一篇求助，并将其保存到数据库
            //Load(int Id)：根据Id从数据库获取一条求助
            //Delete(int Id)：根据Id删除某个求助
            //repoistory：可用于在底层实现上述方法和数据库的连接操作等
            //详见problem类

            //3、设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
            //详见FactoryContext类。



            //4、想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article)么？
            //答：
            //这涉及到编程里一个职责划分的问题，不同于现实世界中，人们所指的应该做某事、能做某事，是一种权限问题，但在程序里，是否应该做某事，是一个能力问题，
            //是否拥有做某件事的资源，据此判断，Publish（）方法所在的类（即Problem类），拥有了一篇文章发布所需满足的所有资源，比如：Body(正文)Title（标题）等，
            //所以不会放在User类，而是放在更适合的problem类里。




            //5、自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
            //1、出栈Pop()，弹出栈顶数据
            //2、入栈Push()，可以一次性压入多个数据
            //3、出 / 入栈检查，
            //（1）如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
            //（2）如果已弹出所有数据，提示“栈已空”
            //MimicStack mimic = new MimicStack(10);
            //Console.WriteLine(mimic.Check()); 
            ///**************************************************************************************************************************************///

            //作业(四)--继承：
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

            //3、实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法
            //Article art = new Article(new string[] { "面向对象", "c#", "后端", "编程开发语言", "Asp", ".NET" });
            //art.Kind = "编程";
            //Console.WriteLine($"现在的时间是：{art.PublishTime},发表的文章种类是{art.Kind},第一个关键字是：{art[1]}");
            //Suggest sug = new Suggest();
            //sug.Publish();


            //4、再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
            //Suggest sug = new Suggest();
            //sug.Publish();
            //Console.WriteLine(sug.Id);

            ///**************************************************************************************************************************************///
            //作业(五)--多态：
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

            ///方法二：
            ///跟HelpMoney联系起来
            //HelpMoney hel = new HelpMoney();
            //Console.WriteLine(hel.MoneyChange(new Article(new string[] { "面向对象" })));
            ////Console.WriteLine(hel.MoneyChange(new Problem { Reward = 20 }));
            ////Console.WriteLine(hel.MoneyChange(new Suggest()));

            ///**************************************************************************************************************************************///
            ///理解错了，更改如下：
            ///**************************************************************************************************************************************///
            //Content fg = new Problem { Author = new User("yezi", "1234a"), Reward = 3 };
            //Content fgg = new Suggest { Author = new User("yezi", "1234a") };
            //Content fggg = new Article(new string[] { "面向对象" }) { Author = new User("yezi", "1234a") };
            //ContentService c = new ContentService();
            //c.Publish(fg);
            //c.Publish(fgg);
            //c.Publish(fggg);
            ///**************************************************************************************************************************************///
            //作业(六)接口：
            //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
            //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，
            //赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
            ///
            Article nb = new Article(new string[] { "面向对象" }) { Author = new User("yezi", "1234a"), Voter = new User("yezi", "1234a"), Title = "接口" };
            nb.Agree();
            //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。
            ///调用：
            //EmailMessage em = new EmailMessage();
            //em.Send();
            //ISendMessage sm = new DBMessage();
            //sm.Send();

            //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
            ///调用：
            //User em = new User("yezi", "1234a");
            //em.Send();//不行，因为重名的时候只能用接口变量去调用
            ISendMessage sm = new User("yezi", "1234a");
            sm.Send();
            IChat ct = new User("yezi", "1234a");
            ct.Send();
            ///**************************************************************************************************************************************///














        }



























    }
}
