using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {

    static class KittyColors {
        static ConsoleColor KeyWord = ConsoleColor.Yellow;
        static ConsoleColor Identifier = ConsoleColor.White;
        static ConsoleColor Number = ConsoleColor.Cyan;
        static ConsoleColor String = ConsoleColor.Green;
        static ConsoleColor Comment = ConsoleColor.Gray;
        static ConsoleColor LineNumbers = ConsoleColor.DarkGray;
        static ConsoleColor Other = ConsoleColor.Magenta;
    }

    abstract class KittyHigh {
        static readonly public Dictionary<string, KittyHigh> Langs = new Dictionary<string, KittyHigh>();
        public abstract void Show(string src, bool linenumbers = false);
        public void Show(StringBuilder src, bool linenumbers = false) => Show(src, linenumbers);
        public string Language { get; protected set; } = "";
    }


    class KittyPL : KittyHigh {
        protected List<string> KeyWords;
        protected string stringstart = "\"";
        protected string stringend = "\"";
        protected string mlstringstart = "@\"";
        protected string mlstringend = "\"";
        protected string astringstart = "'";
        protected string astringend = "'";
        protected string singcomment = "//";
        protected string mulcommentstart = "/*";
        protected string mulcommentend = "*/";
        protected bool mulcomment = true;

        public override void Show(string src, bool linenumbers = false) {
            throw new NotImplementedException();
        }
    }

}
