using DesignPatterns._2.SimpleFactoryPattern;
using DesignPatterns._3.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂模式

            Console.WriteLine("当前模式:{0}", "简单工厂模式");

            Test2.Test();

            Console.WriteLine("--------------------------------------------");

            #endregion

            #region 工厂方法模式

            Console.WriteLine("当前模式:{0}", "工厂方法模式");

            Test3.Test();

            Console.WriteLine("--------------------------------------------");

            #endregion

            #region 抽象工厂模式



            #endregion
















            Console.ReadKey();
        }
    }
}
