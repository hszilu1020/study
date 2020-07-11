using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDemo
{
    class StartUpClass
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new App().Run();
        }
    }
}
