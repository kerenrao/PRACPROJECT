using System;
using System.Windows.Forms;

namespace AndroidDataViewer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // Ensure it's Form1, not MainForm
        }
    }
}
