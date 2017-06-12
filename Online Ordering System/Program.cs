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
            Application.Run(new Form2());
            SQLCommunications.CommBase.ShutDown();
        }
    }
}
