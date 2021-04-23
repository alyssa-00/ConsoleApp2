using System;
using System.Collections.Generic;
using System.Text;

namespace 面向对象
{
    public class HelpMoney:Entity
    {
        //*帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //方法：卖，收取，使用/冻结

        public string ChangeDateTime;
        private int moneyavailable;
        public int MoneyAvailable { get; set; }
        private int moneyfrozen;
        public int MoneyFrozen { get; set; }
        private string[] WayOfGetting;
        private int MoneyChanges;
        private string ChangeInfo;

        public int MoneyChange(Content content)
        {
            MoneyChanges = content.Publish();
            return MoneyChanges;
        }










    }
}
