using System;
namespace ZP.CSharp.TerminalUI
{
    class ConsoleOutputRendering
    {
        public static readonly string Reset = "\x1b[0m";
        public static readonly string Bold = "\x1b[1m";
        public static readonly string Dim = "\x1b[2m";
        public static readonly string Italic = "\x1b[3m";
        public static readonly string Underline = "\x1b[4m";
        public static readonly string Blink = "\x1b[5m";
        public static readonly string Invert = "\x1b[7m";
        public static readonly string Hide = "\x1b[8m";
        public static readonly string Strikethrough = "\x1b[9m";
        public static readonly string NoBold = "\x1b[22m";
        public static readonly string NoItalic = "\x1b[23m";
        public static readonly string NoUnderline = "\x1b[24m";
        public static readonly string NoBlink = "\x1b[25m";
        public static readonly string NoInvert = "\x1b[27m";
        public static readonly string Show = "\x1b[28m";
        public static readonly string NoStrikethrough = "\x1b[29m";
        public static readonly string FGBlack = "\x1b[30m";
        public static readonly string FGRed = "\x1b[31m";
        public static readonly string FGGreen = "\x1b[32m";
        public static readonly string FGYellow = "\x1b[33m";
        public static readonly string FGBlue = "\x1b[34m";
        public static readonly string FGMagenta = "\x1b[35m";
        public static readonly string FGCyan = "\x1b[36m";
        public static readonly string FGWhite = "\x1b[37m";
        public static string ColorFromRGB(int r, int g, int b, bool bg = false)
        {
            if (r < 0 || r > 255)
            {
                throw new ArgumentOutOfRangeException("r", r, "Red is too much or too little.");
            }
            if (g < 0 || g > 255)
            {
                throw new ArgumentOutOfRangeException("g", g, "Green is too much or too little.");
            }
            if (b < 0 || b > 255)
            {
                throw new ArgumentOutOfRangeException("b", b, "Blue is too much or too little.");
            }
            return $"\x1b[{(bg ? 48 : 38)};2;{r};{g};{b}m";
        }
        public static string Hyperlink(string url, string desc, string id)
        {
            return $"\x1b]8;id={id};{url}\x1b\\{desc}\x1b]8;;\x1b\\";
        }
    }
}

