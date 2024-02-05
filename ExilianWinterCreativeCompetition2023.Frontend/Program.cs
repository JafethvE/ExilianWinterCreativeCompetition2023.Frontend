using System;
using System.Windows.Forms;

namespace ExilianWinterCreativeCompetition2023.Frontend
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
            Application.Run(new ExilianWinterCreativeCompetition2023Form());
        }
    }
}
