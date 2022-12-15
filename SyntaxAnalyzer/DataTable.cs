using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAnalyzer
{
    public static class DataTable
    {
        public static List<string> GetServiceWords()
        {
            return new List<string>()
            {
                "if",
                "dim",
                "then",
                "else",
                "int",
                "float",
                "bool",
                "for",
                "do",
                "while",
                "loop",
                "read",
                "write",
                "true",
                "false",
                "do",
                "end_else",
                "do_while",
                "%",
                "!",
                "$"
            };
        }

        public static List<string> GetSeparators()
        {
            return new List<string>()
            {
                "NE",
                "EQ",
                "LT",
                "LE",
                "GT",
                "GE",
                "plus",
                "min",
                "or",
                "mult",
                "div",
                "and",
                "=",
                "{",
                "}",
                ";",
                ",",
                ":",
                "/n",
                "(",
                ")",
                "*",
                "~"
            };
        }
           
    }
}
