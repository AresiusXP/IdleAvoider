using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Runtime.InteropServices;
using WindowsInput;

namespace IdleTools
{
    public static class MouseMove
    {
        /*[DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public SendInputEventType type;
            public MouseKeybdhardwareInputUnion mkhi;
        }
        [StructLayout(LayoutKind.Explicit)]
        struct MouseKeybdhardwareInputUnion
        {
            [FieldOffset(0)]
            public MouseInputData mi;

            [FieldOffset(0)]
            public KEYBDINPUT ki;

            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }
        struct MouseInputData
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public MouseEventFlags dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [Flags]
        enum MouseEventFlags : uint
        {
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_VIRTUALDESK = 0x4000,
            MOUSEEVENTF_ABSOLUTE = 0x8000
        }
        enum SendInputEventType : int
        {
            InputMouse,
            InputKeyboard,
            InputHardware
        }

        static void MoveSpecific(int dx, int dy)
        {
            var inp = new INPUT();
            inp.type = SendInputEventType.InputMouse;
            inp.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE;
            inp.mkhi.mi.dx = dx;
            inp.mkhi.mi.dy = dy;
            inp.mkhi.mi.mouseData = 0;
            inp.mkhi.mi.time = 0;
            inp.mkhi.mi.dwExtraInfo = (IntPtr)0;

            SendInput(1, ref inp, Marshal.SizeOf(new INPUT()));
        }*/

        public static void Move()
        {
            Random Randomizer = new Random();
            int PosCount = Randomizer.Next(0, 300);
            Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            IInputSimulator Input = new InputSimulator();
            while (PosCount != 0)
            {
                switch (Randomizer.Next(0, 3))
                {
                    case 0:
                        Input.Mouse.MoveMouseTo(Cursor.Position.X + 1, Cursor.Position.Y + 1);
                        PosCount--;
                        Thread.Sleep(50);
                        break;
                    case 1:
                        Input.Mouse.MoveMouseTo(Cursor.Position.X - 1, Cursor.Position.Y + 1);
                        PosCount--;
                        Thread.Sleep(50);
                        break;
                    case 2:
                        Input.Mouse.MoveMouseTo(Cursor.Position.X - 1, Cursor.Position.Y - 1);
                        PosCount--;
                        Thread.Sleep(50);
                        break;
                    case 3:
                        Input.Mouse.MoveMouseTo(Cursor.Position.X + 1, Cursor.Position.Y - 1);
                        PosCount--;
                        Thread.Sleep(50);
                        break;
                }

            }

        }
    }
}
