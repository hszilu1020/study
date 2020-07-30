using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2.SimpleFactoryPattern
{
    /// <summary>
    /// 西红柿
    /// </summary>
    public class Tomato : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿");
        }
    }
}
