using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    class Repoistory
    {
        //1、定义一个仓库（Repoistory）类，用于存取对象，其中包含：
        //一个int类型的常量version
        //一个静态只读的字符串connection，以后可用于连接数据库

        private const int version =0;
        public static readonly  string connection;

        //思考Respoitory应该是static类还是实例类更好？
        ///答：实例类,实例类还可以装静态成员，但是静态类就不能再装实例成员了


        private int Info;
        public static  string Data;//数据总仓库，应该是静态的
        public void Save()
        {
            Console.WriteLine("数据已存入仓库。。。");
        }
        public void Get(Entity entity)
        {
            if (entity.Id== Info)//多态
            {
                Console.WriteLine("您需要的数据已取出。。。");//这里应该是要返回需要取出的数据
            }
            
        }

















    }
}
