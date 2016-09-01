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
    public static class EditNotepad
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern bool SetForegroundWindow(IntPtr hwnd);



        static IntPtr CreateNotepad(Process NotepadProc)
        {
            //Start notepad
            NotepadProc.Start();
            return NotepadProc.MainWindowHandle;
        }
        static void WriteOnNotepad(IntPtr NotepadHandle)
        {
            //Sleep for 100ms or it won't find Notepad
            Thread.Sleep(100);

            //Select Notepad window
            SetForegroundWindow(NotepadHandle);
            InputSimulator Input = new InputSimulator();
            //Write on the new document
            for (int i = 0; i < 50; i++)
            {
                Input.Keyboard.TextEntry(WriteRandomChars());
                Thread.Sleep(100);
            }
        }
        static string WriteRandomChars()
        {
            Random Randomizer = new Random();
            int CharCode = Randomizer.Next(0, 25);
            char RandomChar = (char)('a' + CharCode);
            return RandomChar.ToString();
        }
        public static void WriteNotepad()
        {
            //Create Notepad process
            Process NotepadProc = new Process();
            ProcessStartInfo ProcInfo = new ProcessStartInfo(@"C:\Windows\system32\notepad.exe");
            NotepadProc.StartInfo = ProcInfo;

            IntPtr NotepadHandle = CreateNotepad(NotepadProc);
            WriteOnNotepad(NotepadHandle);
            NotepadProc.Kill();
        }
        public static void PressF15()
        {
            InputSimulator Input = new InputSimulator();
            Input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.F15);
        }
    }
}
