using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;  // Add reference to Microsoft.VisualBasic!!

namespace Projeto_Principal
{
    class Program : WindowsFormsApplicationBase
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new Program();
            app.EnableVisualStyles = true;
            app.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
            app.MainForm = new MainMenu();
            app.Run(args);
        }
    }
}