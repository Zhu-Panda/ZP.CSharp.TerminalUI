using System;
using ZP.CSharp.TerminalUI;
namespace ZP.CSharp.TerminalUI
{
    public static class Window
    {
        public static void EnterBuffer()
        {
            Console.Write("\x1b[?1049h");
            Console.Write("\x1b[1;1H");
        }
        public static void ExitBuffer()
        {
            Console.Write("\x1b[?1049l");
        }
    }
}