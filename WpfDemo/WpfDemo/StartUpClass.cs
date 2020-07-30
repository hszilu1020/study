using System;
using WpfDemo.View;

namespace WpfDemo
{
    static class StartUpClass
    {
        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        static void Main()
        {
            new App().Run();
        }
    }
}
