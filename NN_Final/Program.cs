using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NN_Final
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NN_Final());
        }
    }
}
