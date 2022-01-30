using System;
namespace ZP.CSharp.TerminalUI
{
    class ConsoleSGRs
    {
        public static readonly string Reset = "\x1b[0m";
        public static readonly string Bold = "\x1b[1m";
        public static readonly string Dim = "\x1b[2m";
        public static readonly string Italic = "\x1b[3m";
        public static readonly string Underline = "\x1b[4m";
        public static readonly string Blink = "\x1b[5m";
        public static readonly string Invert = "\x1b[7m";
        public static readonly string Hide = "\x1b[8m";
    }
}

