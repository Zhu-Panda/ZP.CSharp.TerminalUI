using System;
using ZP.CSharp.TerminalUI;
namespace ZP.CSharp.TerminalUI
{
    public static class BorderExtensions
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
}