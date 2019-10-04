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
    }

    abstract class KittyHigh {
        static readonly public Dictionary<string, KittyHigh> Langs = new Dictionary<string, KittyHigh>();
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
        

        public override void Show(string src, bool linenumbers = false) {
            string word = "";
            void showword() {
                var col = KittyColors.Other;
                if (KeyWords.Contains(word) || (caseinsensitive && KeyWords.Contains(word.ToLower())))
                    col = KittyColors.KeyWord;
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
                    singcomm = singcomm || (p < lines[i].Length - 1 && lines[i].Substring(p, singcomment.Length) == singcomment && (!singstring) && (!mulcomm));
                    mulcomm = mulcomm || (p < lines[i].Length - 1 && lines[i].Substring(p, mulcommentstart.Length) == mulcommentstart && (!singstring) & (!singcomm) && mulcomment);
                    singstring = singstring || (p < lines[i].Length - 1 && lines[i].Substring(p, stringstart.Length) == stringstart && (!singcomm) && (!mulcomm));
                    if (singstring) {
                        Console.ForegroundColor = KittyColors.String;
                        Console.Write($"{ch}");
                        if (wassingstring && p < lines[i].Length  && lines[i].Substring(p, stringend.Length) == stringend && !stringescape)
                            singstring = false;
                        else
                            stringescape = ch == escape && !stringescape;
                    } else if (mulcomm) {
                        Console.ForegroundColor = KittyColors.Comment;
                        Console.Write($"{ch}");
                        if (p < lines[i].Length  && lines[i].Substring(p, stringend.Length) == mulcommentend)
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
                Console.WriteLine();
            }

        }
    }

    class KittyNiks : KittyHigh {
        public KittyNiks() { Language = "Unrecognized"; }
        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\r");
            var lines = src.Split('\r');
            for(int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1); LineNumber(i + 1);
                Console.ForegroundColor = KittyColors.Other; Console.WriteLine(lines[i]);
            }
        }
    }
}
