using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    sealed class User:Entity
    {
        //每一个User对象一定有Name和Password赋值
        public User(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }

        //作业（一）
        //1、观察“一起帮”的：
        //*注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //*求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //*帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //2、为这些类的字段和方法设置合适的访问修饰符。

        private string _name;//字段私有
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        public string Name
        {
            get => _name;
            set
            {

                if (value == "admin")
                {
                    _name = "系统管理员";

                }
                else
                {
                    _name = value;
                }
            }

        }//属性public
        private string _password;
        //user.Password在类的外部只能改不能读
        public string Password
        {
             set { _password = value; } //是否可以写成set{;}
        }
        private string InvitedBy;
        private void Register()
        {

        }
        public bool LogOn(out string output)
        {
            Console.WriteLine("请输入验证码:");
            string origin_u = "yezi";
            string origin_c = "1234a";
            string origin_v = "345q";

            //string username = Console.ReadLine();
            //string code = Console.ReadLine();
            string verification = Console.ReadLine();

            bool success = false;
            if (origin_u == _name && origin_c == _password && origin_v == verification)//name和password在new的时候已经传进来
            {
                output = "恭喜！登录成功!";
                success = true;
            }
            else
            {
                if (origin_u != _name)
                {
                    output = "用户名不存在";
                }
                else if (origin_v != verification)
                {
                    output = "验证码错误";
                }
                else
                {
                    output = "用户名或密码错误";
                }
            }
            return success;


        }







    }
















}
