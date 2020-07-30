using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2.SimpleFactoryPattern
{
    public class Test2
    {     
        public static void Test()
        {
            Food f1 = FoodFactory.GetFood(FoodType.Tomato);
            f1.Print();

            Food f2 = FoodFactory.GetFood(FoodType.Potato);
            f2.Print();

            Food f3 = FoodFactory.GetFood(FoodType.Tofu);
            f3.Print();
        }
    }
}
