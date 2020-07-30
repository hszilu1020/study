using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    /// <summary>
    /// 西红柿工厂类
    /// </summary>
    public class TomatoFactory : FoodFactory
    {
        Food food = null;

        public override Food GetFood()
        {
            food = new Tomato();
            return food;
        }
    }
}
