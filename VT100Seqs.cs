using System;
namespace ZP.CSharp.TerminalUI
{
    class VT100Seqs
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
        public static string VT100SeqFromRGB(int r, int g, int b, bool bg = false)
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
    }
}

