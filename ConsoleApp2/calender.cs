using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"TODAY'S DATE IS {now}");
            Console.ReadLine();


        }
        internal static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;


        }

    }
}
