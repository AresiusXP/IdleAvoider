using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsInput;

namespace IdleTools
{
    public static class OpenCalc
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        static IntPtr NewCalc(Process CalcProc)
        {
            //Start Calc
            CalcProc.Start();
            return CalcProc.MainWindowHandle;
        }
        static void UseCalc(IntPtr CalcHandle)
        {
            //Sleep for 100ms or it won't find Notepad
            Thread.Sleep(100);

            //Select calc window
            SetForegroundWindow(CalcHandle);
            Thread.Sleep(200);
            IInputSimulator Input = new InputSimulator();

            //Write
            for (int i = 0; i < 11; i++)
            {
                Input.Keyboard.TextEntry(WriteRandomNumbers());
                Thread.Sleep(1000);
            }
        }
        static string WriteRandomNumbers()
        {
            Random Randomizer = new Random();
            int CharCode = Randomizer.Next(0, 9);
            return CharCode.ToString();
        }
        public static void RunCalc()
        {
            //Create Calc process
            Process CalcProc = new Process();
            ProcessStartInfo ProcInfo = new ProcessStartInfo(@"C:\Windows\system32\calc.exe");
            CalcProc.StartInfo = ProcInfo;

            IntPtr CalcHandle = NewCalc(CalcProc);
            UseCalc(CalcHandle);
            Process.GetProcessesByName("Calculator").FirstOrDefault().Kill();
        }
    }
}
