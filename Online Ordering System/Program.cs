using Online_Ordering_System.Front_end;
using System;
using System.Windows.Forms;

namespace Online_Ordering_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLCommunications.CommBase.Intialize();
            Application.Run(new Admin());
            SQLCommunications.CommBase.ShutDown();
        }
    }
}
