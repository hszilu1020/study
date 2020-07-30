using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    /// <summary>
    /// 豆腐工厂类
    /// </summary>
    public class TofuFactory : FoodFactory
    {
        Food food = null;

        public override Food GetFood()
        {
            food = new Tofu();
            return food;
        }
    }
}
