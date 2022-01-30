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
    }
}

