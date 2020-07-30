using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3.FactoryMethodPattern
{
    public class Test3
    {
        public static void Test()
        {
            FoodFactory tomatoFactory = new TomatoFactory();
            Food tomato1 = tomatoFactory.GetFood();
            tomato1.Print();
            Food tomato2 = tomatoFactory.GetFood();
            tomato2.Print();

            FoodFactory potatoFactory = new PotatoFactory();
            Food potato1 = potatoFactory.GetFood();
            potato1.Print();
            Food potato2 = potatoFactory.GetFood();
            potato2.Print();

            FoodFactory tofuFactory = new TofuFactory();
            Food tofu1 = tofuFactory.GetFood();
            tofu1.Print();
            Food tofu2 = tofuFactory.GetFood();
            tofu2.Print();
        }
    }
}
