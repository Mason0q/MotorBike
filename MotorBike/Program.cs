using System;
using System.Windows.Forms;
using MotorBike;

namespace MotorBike
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }// Выполнил Калашников Артём
    }
}