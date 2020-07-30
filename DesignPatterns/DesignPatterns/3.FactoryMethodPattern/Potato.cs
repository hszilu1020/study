using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    /// <summary>
    /// 土豆
    /// </summary>
    public class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆");
        }
    }
}
