﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    /// <summary>
    /// 豆腐
    /// </summary>
    public class Tofu : Food
    {
        public override void Print()
        {
            Console.WriteLine("豆腐");
        }
    }
}
