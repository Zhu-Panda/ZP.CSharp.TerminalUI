using System;
using System.Collections;
using System.Threading.Tasks;
namespace ZP.CSharp.TerminalUI
{
    enum Border
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Vertical,
        Horizontal
    }
    static class BorderExtensions
    {
        public static char MapToChar(this Border piece)
        {
            return piece switch
            {
                Border.TopLeft => '┌',
                Border.TopRight => '┐',
                Border.BottomLeft => '└',
                Border.BottomRight => '┘',
                Border.Horizontal => '─',
                Border.Vertical => '│',
                _ => '?'
            };
        }
   }
    class Window
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
    class Program
    {
        public static void Main(string[] args)
        {
            Window.EnterBuffer();
            (int x, int y) cursor = Console.GetCursorPosition();
            var b = new Box(20, 20, 0, 0, ".NET Core!");
            b.Draw(9);
            Thread.Sleep(5000);
            Window.ExitBuffer();
        }
    }
}
