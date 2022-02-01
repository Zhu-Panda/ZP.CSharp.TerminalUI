using System;
using ZP.CSharp.TerminalUI;
namespace ZP.CSharp.TerminalUI
{
    class ConsoleOutput
    {
        public const string Default = "\x1b[0m";
        public const string Bold = "\x1b[1m";
        public const string Dim = "\x1b[2m";
        public const string Italic = "\x1b[3m";
        public const string Underline = "\x1b[4m";
        public const string Blink = "\x1b[5m";
        public const string Invert = "\x1b[7m";
        public const string Hide = "\x1b[8m";
        public const string Strikethrough = "\x1b[9m";
        public const string NoBold = "\x1b[22m";
        public const string NoItalic = "\x1b[23m";
        public const string NoUnderline = "\x1b[24m";
        public const string NoBlink = "\x1b[25m";
        public const string NoInvert = "\x1b[27m";
        public const string Show = "\x1b[28m";
        public const string NoStrikethrough = "\x1b[29m";
        public const string FGBlack = "\x1b[30m";
        public const string FGRed = "\x1b[31m";
        public const string FGGreen = "\x1b[32m";
        public const string FGYellow = "\x1b[33m";
        public const string FGBlue = "\x1b[34m";
        public const string FGMagenta = "\x1b[35m";
        public const string FGCyan = "\x1b[36m";
        public const string FGWhite = "\x1b[37m";
        public const string FGDefault = "\x1b[39m";
        public const string BGBlack = "\x1b[40m";
        public const string BGRed = "\x1b[41m";
        public const string BGGreen = "\x1b[42m";
        public const string BGYellow = "\x1b[43m";
        public const string BGBlue = "\x1b[44m";
        public const string BGMagenta = "\x1b[45m";
        public const string BGCyan = "\x1b[46m";
        public const string BGWhite = "\x1b[47m";
        public const string BGDefault = "\x1b[49m";
        public const string FGBrightBlack = "\x1b[90m";
        public const string FGBrightRed = "\x1b[91m";
        public const string FGBrightGreen = "\x1b[92m";
        public const string FGBrightYellow = "\x1b[93m";
        public const string FGBrightBlue = "\x1b[94m";
        public const string FGBrightMagenta = "\x1b[95m";
        public const string FGBrightCyan = "\x1b[96m";
        public const string FGBrightWhite = "\x1b[97m";
        public const string BGBrightBlack = "\x1b[100m";
        public const string BGBrightRed = "\x1b[101m";
        public const string BGBrightGreen = "\x1b[102m";
        public const string BGBrightYellow = "\x1b[103m";
        public const string BGBrightBlue = "\x1b[104m";
        public const string BGBrightMagenta = "\x1b[105m";
        public const string BGBrightCyan = "\x1b[106m";
        public const string BGBrightWhite = "\x1b[107m";
        public static string ColorFrom256Table(int id, bool bg = false)
        {
            if (id < 0 || id > 255)
            {
                throw new ArgumentOutOfRangeException("id", id, "Color ID is too much or too little.");
            }
            return $"\x1b[{(bg ? 48 : 38)};5;{id}m";
        }
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
        public static string Hyperlink(string url, string desc, string id = "")
        {
            return $"\x1b]8;id={id};{url}\x1b\\{desc}\x1b]8;;\x1b\\";
        }
        
    }
}

