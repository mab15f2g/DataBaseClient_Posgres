using Microsoft.TeamFoundation.Common.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DBClient
{

   
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);                
            Console.WriteLine("Debug Console");
            Application.Run(new Form1());


        }
    }
}
