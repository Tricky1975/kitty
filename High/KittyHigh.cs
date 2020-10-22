// Lic:
// High/KittyHigh.cs
// Kitty
// version: 20.10.22
// Copyright (C) 2019, 2020 Jeroen P. Broks
// This software is provided 'as-is', without any express or implied
// warranty.  In no event will the authors be held liable for any damages
// arising from the use of this software.
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
// 1. The origin of this software must not be misrepresented; you must not
// claim that you wrote the original software. If you use this software
// in a product, an acknowledgment in the product documentation would be
// appreciated but is not required.
// 2. Altered source versions must be plainly marked as such, and must not be
// misrepresented as being the original software.
// 3. This notice may not be removed or altered from any source distribution.
// EndLic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {

    static class KittyColors {
        static public ConsoleColor KeyWord = ConsoleColor.Yellow;
        static public ConsoleColor Identifier = ConsoleColor.White;
        static public ConsoleColor Number = ConsoleColor.Cyan;
        static public ConsoleColor String = ConsoleColor.Green;
        static public ConsoleColor Comment = ConsoleColor.DarkGray;
        static public ConsoleColor LineNumbers = ConsoleColor.DarkGray;
        static public ConsoleColor Other = ConsoleColor.Gray;
        static public ConsoleColor Error = ConsoleColor.DarkRed;
        static public ConsoleColor Attribute = ConsoleColor.Blue;
        static public ConsoleColor BaseType = ConsoleColor.Magenta;
    }

    abstract class KittyOutput {

        ~KittyOutput()
        {
            Console.ResetColor();
        }

        abstract public void Write(string a);
        abstract public void WriteLine(string a);
        public void WriteLine() => WriteLine("");
        public ConsoleKeyInfo ReadKey() => Console.ReadKey();
        public ConsoleKeyInfo ReadKey(bool b) => Console.ReadKey(b);
        public void ResetColor() { ForegroundColor = ConsoleColor.Gray; BackgroundColor = ConsoleColor.Black; }
        public void Write(object a) => Write($"{a}");
        public void WriteLine(object a) => WriteLine($"{a}");
        public ConsoleColor ForegroundColor = ConsoleColor.Gray;
        public ConsoleColor BackgroundColor = ConsoleColor.Black;
        public int WindowHeight = 25; 
    }

    class KittyCLI:KittyOutput {
        public override void Write(string a) {
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
            Console.Write(a);
        }
        public override void WriteLine(string a) => Console.Write($"{a}\n");
        public KittyCLI() {
            WindowHeight = Console.WindowHeight;
        }
    }

    abstract class KittyHigh {
        static readonly public SortedDictionary<string, KittyHigh> Langs = new SortedDictionary<string, KittyHigh>();
        static KittyOutput _ko = null;
        static public int NumLines => Console.WindowHeight;
        static public int PagLines = 0;
        static public bool BrkLines = false;
        static public KittyOutput Console {
            get {
                if (_ko == null) _ko = new KittyCLI();
                return _ko;
            }
            set {
                System.Diagnostics.Debug.WriteLine("New Console For KittyHigh set");
                _ko = value;
            }
        }

        static public void PageBreak() {
            if (!BrkLines) return;
            PagLines++;
            if (PagLines>=NumLines-2) {
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(" More ");
                Console.ResetColor();
                Console.Write("\b\b\b\b\b\b\b");
                ConsoleKeyInfo k;
                bool loopme = true;
                do {
                    loopme = false;
                    k = Console.ReadKey(true);
                    Console.Write("       ");
                    Console.Write("\b\b\b\b\b\b\b");
                    switch (k.Key) {
                        case ConsoleKey.Enter:
                            PagLines = 0;
                            break;
                        case ConsoleKey.Spacebar:
                            PagLines--;
                            break;
                        case ConsoleKey.Escape:
                            BrkLines = false;
                            break;
                        default:
                            loopme = true;
                            break;
                    }
                } while (loopme);
            }
        }

        public static void WriteLine(string a="") {
            Console.WriteLine(a);
            PageBreak();
        }

        public abstract void Show(string src, bool linenumbers = false);
        public void Show(StringBuilder src, bool linenumbers = false) => Show(src, linenumbers);
        public string Language { get; protected set; } = "";
        public static void LineNumber(int ln) {
            Console.ForegroundColor = KittyColors.LineNumbers;
            Console.Write($"{ln.ToString("D9")} | ");
        }

        static public void Init() {
            Langs["OTHER"] = new KittyNiks();
        }
    }


    class KittyPL : KittyHigh {
        protected List<string> KeyWords= new List<string>();
        protected List<string> BaseTypes = new List<string>();
        protected string stringstart = "\"";
        protected string stringend = "\"";
        protected string mlstringstart = "@\"";
        protected string mlstringend = "\"";
        protected string astringstart = "'";
        protected string astringend = "'";
        protected string singcomment = "//";
        protected string mulcommentstart = "/*";
        protected string mulcommentend = "*/";
        protected char escape = '\\';
        protected bool mulcomment = true;
        protected bool mulcommentfullline = false; // Needed for BlitzMax where commands taking up a full line are used for multi line comments. This is not entirely fool-proof, but it'll have to do.
        protected bool caseinsensitive = false;
        protected bool supcom = true;


        public override void Show(string src, bool linenumbers = false) {
            string word = "";
            var mle = 0;
            void showword() {
                var col = KittyColors.Other;
                if (KeyWords.Contains(word) || (caseinsensitive && KeyWords.Contains(word.ToLower())))
                    col = KittyColors.KeyWord;
                else if (BaseTypes.Contains(word) || (caseinsensitive && BaseTypes.Contains(word.ToLower())))
                    col = KittyColors.BaseType;
                else {                  
                    switch (word.Substring(0, 1).ToUpper()) { // Not the most elegant method, but what works, that works!
                        case "A":
                        case "B":
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "H":
                        case "I":
                        case "J":
                        case "K":
                        case "L":
                        case "M":
                        case "N":
                        case "O":
                        case "P":
                        case "Q":
                        case "R":
                        case "S":
                        case "T":
                        case "U":
                        case "V":
                        case "W":
                        case "X":
                        case "Y":
                        case "Z":
                        case "_":
                            col = KittyColors.Identifier;
                            break;
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            col = KittyColors.Number;
                            break;
                    }
                }
                Console.ForegroundColor = col;
                Console.Write(word);
            }
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');
            var mulcomm = false;
            for (int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1);
                word = "";
                var singcomm = false;
                var singstring = false;
                var stringescape = false;
                var wassingstring = false;
                for (int p = 0; p < lines[i].Length; p++) {
                    var ch = lines[i][p];
                    // Console.WriteLine($"DEBUG! {lines[i].Substring(p, singcomment.Length)} {singcomment}");
                    wassingstring = singstring;
                    singcomm = singcomm || (p < lines[i].Length - 1 && lines[i].Substring(p, singcomment.Length) == singcomment && (!singstring) && (!mulcomm) && supcom);
                    try {
                        mulcomm = mulcomm || (p < lines[i].Length - 1 && lines[i].Substring(p, Math.Min(lines[i].Length-p, mulcommentstart.Length)) == mulcommentstart && (!singstring) & (!singcomm) && mulcomment);
                    } catch (Exception e) {
                        System.Diagnostics.Debug.WriteLine($"Error: {e.Message} (parsing line {i+1}/{lines.Length}; pos {p})");
                        System.Console.Beep(); mle++;
                        //mulcomm = false;
                    }
                    singstring = singstring || (p < lines[i].Length - 1 && lines[i].Substring(p, stringstart.Length) == stringstart && (!singcomm) && (!mulcomm));
                    if (singstring) {
                        Console.ForegroundColor = KittyColors.String;
                        Console.Write($"{ch}");
                        if (wassingstring && p < lines[i].Length && lines[i].Substring(p, stringend.Length) == stringend && !stringescape)
                            singstring = false;
                        else
                            stringescape = ch == escape && !stringescape;
                    } else if (mulcomm) {
                        Console.ForegroundColor = KittyColors.Comment;
                        Console.Write($"{ch}");
                        if (p < lines[i].Length - (mulcommentend.Length - 1) && lines[i].Substring(p, mulcommentend.Length) == mulcommentend)
                            mulcomm = false;
                    } else if (singcomm) {
                        Console.ForegroundColor = KittyColors.Comment;
                        Console.Write($"{ch}");
                    } else {
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == '_' || (ch >= '0' && ch <= '9'))
                            word += $"{ch}";
                        else {
                            if (word != "") showword(); word = $"{ch}"; showword(); word = "";
                        }
                    }
                }
                if (word != "") showword();
                WriteLine();
            }
            if (mle > 0) System.Diagnostics.Debug.WriteLine($"Number of errors on multi-line-comments: {mle}");
        }
    }

    class KittyNiks : KittyHigh {
        public KittyNiks() { Language = "Unrecognized"; }
        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\r");
            var lines = src.Split('\n');
            for(int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1); 
                Console.ForegroundColor = KittyColors.Other; WriteLine(lines[i]);
            }
        }
    }

    // Markup support by freezernick
    class KittyMarkup : KittyHigh
    {
        protected string stringstart = "\"";
        protected string stringend = "\"";
        protected bool mulcomment = true;
        protected string mulcommentstart = "<!--";
        protected string mulcommentend = "-->";
        protected string opentagchar = "<";
        protected string closetagchar = ">";
        protected string endtagchar = "/>";
        protected char escape = '\\';

        public override void Show(string src, bool linenumbers = false)
        {
            bool intag = false;
            string word = "";
            void showword()
            {
                var col = KittyColors.Other;
                if (word.StartsWith(opentagchar) || word.EndsWith(endtagchar) || word.EndsWith(closetagchar))
                    col = KittyColors.KeyWord;
                if (intag)
                    col = KittyColors.Attribute;
                Console.ForegroundColor = col;
                Console.Write(word);
            }
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');
            bool mulcomm = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (linenumbers) LineNumber(i + 1);
                word = "";
                intag = false;
                var singstring = false;
                var stringescape = false;
                bool wassingstring;

                for (int p = 0; p < lines[i].Length; p++)
                {
                    var ch = lines[i][p];

                    wassingstring = singstring;
                    singstring = singstring || (p < lines[i].Length - 1 && lines[i].Substring(p, stringstart.Length) == stringstart);
                    mulcomm = mulcomm || (p < lines[i].Length - 3 && lines[i].Substring(p, mulcommentstart.Length) == mulcommentstart && !singstring && mulcomment);
                    if (singstring)
                    {
                        Console.ForegroundColor = KittyColors.String;
                        Console.Write($"{ch}");
                        if (wassingstring && p < lines[i].Length && lines[i].Substring(p, stringend.Length) == stringend && !stringescape)
                            singstring = false;
                        else
                            stringescape = ch == escape && !stringescape;
                    }
                    else if (mulcomm)
                    {
                        Console.ForegroundColor = KittyColors.Comment;
                        Console.Write($"{ch}");
                        if (p < lines[i].Length - 2 && lines[i].Substring(p, mulcommentend.Length) == mulcommentend)
                        {
                            Console.Write($"{lines[i][p + 1]}");
                            Console.Write($"{lines[i][p + 2]}");
                            p = p + 2;
                            mulcomm = false;
                        }
                    }
                    else if (word == "" && ch == '<')
                    {
                        word += $"{ch}";
                        int q = p;
                        bool inline = true;
                        while (inline)
                        {
                            q++;
                            if (lines[i][q] == '=')
                            {
                                word += lines[i][q];
                                p = q;
                                showword();
                                word = "";
                                intag = true;
                                inline = false;
                            }
                            else if (lines[i][q] == '>')
                            {
                                word += lines[i][q];
                                p = q;
                                inline = false;
                                intag = false;
                                showword();
                                word = "";
                            }
                            else if (lines[i][q] == ' ')
                            {
                                word += lines[i][q];
                                p = q;
                                showword();
                                word = "";
                                inline = false;
                                intag = true;
                            }
                            else
                            {
                                word += lines[i][q];
                            }
                        }
                    }
                    else if (word == "" && intag && ch != ' ' && ch != '>' && ch != '/')
                    {
                        word += $"{ch}";
                        int q = p;
                        bool inline = true;
                        while (inline)
                        {
                            q++;
                            if (lines[i][q] == '=')
                            {
                                word += lines[i][q];
                                p = q;
                                showword();
                                word = "";
                                inline = false;
                            }
                            else if (lines[i][q] == '>')
                            {
                                word += lines[i][q];
                                p = q;
                                inline = false;
                                intag = false;
                            }
                            else
                            {
                                word += lines[i][q];
                            }
                        }
                    }
                    else if (word == "" && intag && ch == '/' && lines[i][p + 1] == '>')
                    {
                        p += 1;
                        word = "/>";
                        intag = false;
                        showword();
                        word = "";
                    }
                    else
                    {
                        if (ch == '>')
                            intag = false;
                        if (word != "") showword(); word = $"{ch}"; showword(); word = "";
                    }
                }
                if (word != "") showword();
                WriteLine();
            }
        }
    }
}