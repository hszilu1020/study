using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    /// <summary>
    /// 食物抽象工厂类
    /// </summary>
    public abstract class FoodFactory
    {
        public abstract Food GetFood();
    }
}
