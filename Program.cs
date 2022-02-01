using System;
using System.Threading.Tasks;
namespace ZP.CSharp.TerminalUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Window.EnterBuffer();
            var b = new Box(20, 20, 0, 0, ".NET Core!");
            b.Draw(9);
            Thread.Sleep(5000);
            Window.ExitBuffer();
        }
    }
}
