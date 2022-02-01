using System;
using ZP.CSharp.TerminalUI;
namespace ZP.CSharp.TerminalUI
{
    class Box
    {
        public int Height;
        public int Width;
        public int Left;
        public int Top;
        public string Title;
        public Box(int height, int width, int left, int top, string title)
        {
            this.Height = height;
            this.Width = width;
            this.Left = left;
            this.Top = top;
            this.Title = title;
        }
        public void Draw()
        {
            Draw(this.Height, this.Width, this.Left, this.Top, this.Title);
        }
        public void Draw(int titleSpacing)
        {
            Draw(this.Height, this.Width, this.Left, this.Top, this.Title, titleSpacing);
        }
        public void Draw(string boxStyle)
        {
            Draw(this.Height, this.Width, this.Left, this.Top, this.Title, 2, boxStyle);
        }
        public void Draw(int titleSpacing, string boxStyle)
        {
            Draw(this.Height, this.Width, this.Left, this.Top, this.Title, titleSpacing, boxStyle);
        }
        public void Draw(int height, int width, int left, int top, string title, int titleSpacing = 2, string boxStyle = ConsoleOutput.Default)
        {
            if (titleSpacing > (width - 2 - title.Length))
            {
                throw new InvalidOperationException("Spacing and/or title length exceeds width.");
            }
            Console.Write($"\x1b[{top + 1};{left + 1}H{boxStyle}");
            Console.Write(Border.TopLeft.MapToChar());            
            for (int i = 0; i < (width - 2); i++)
            {
                if (i >= titleSpacing && (i - titleSpacing) < title.Length)
                {
                    Console.Write(title[i - titleSpacing]);
                }
                else
                {
                    Console.Write(Border.Horizontal.MapToChar());
                }
            }
            Console.Write($"{Border.TopRight.MapToChar()}{ConsoleOutput.Default}\n");
            for (int i = 0; i < (height - 2); i++)
            {
                Console.Write($"\x1b[{left + 1}G{boxStyle}{Border.Vertical.MapToChar()}{new string(' ', width - 2)}{Border.Vertical.MapToChar()}{ConsoleOutput.Default}");
                if (i != (height - 2))
                {
                    Console.Write('\n');
                }
            };
            Console.Write($"\x1b[{left + 1}G{boxStyle}{Border.BottomLeft.MapToChar()}{new string(Border.Horizontal.MapToChar(), width - 2)}{Border.BottomRight.MapToChar()}{ConsoleOutput.Default}");
        }
    }
}