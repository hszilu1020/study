using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2.SimpleFactoryPattern
{
    /// <summary>
    /// 食物工厂类
    /// </summary>
    public class FoodFactory
    {
        public static Food GetFood(FoodType type)
        {
            Food food = null;
            switch (type)
            {
                case FoodType.Tomato:
                    food = new Tomato();
                    break;
                case FoodType.Potato:
                    food = new Potato();
                    break;
                case FoodType.Tofu:
                    food = new Tofu();
                    break;
            }
            return food;
        }
    }
}
