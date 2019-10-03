using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighNIL : KittyPL {
        public KittyHighNIL() {
            // Not complete yet, but for now this will do!
            KeyWords.Add("class");
            KeyWords.Add("group");
            KeyWords.Add("module");
            KeyWords.Add("global");
            KeyWords.Add("private");
            KeyWords.Add("end");
            KeyWords.Add("table");
            KeyWords.Add("void");
            KeyWords.Add("string");
            KeyWords.Add("int");
            KeyWords.Add("quickmeta");
            KeyWords.Add("bool");
            KeyWords.Add("switch");
            KeyWords.Add("case");
            KeyWords.Add("default");
            // KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("elseif");
            KeyWords.Add("do");
            KeyWords.Add("while");
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("abstract");
            KeyWords.Add("override");
            KeyWords.Add("self");
            KeyWords.Add("get");
            KeyWords.Add("set");
            KeyWords.Add("try");
            KeyWords.Add("catch");
            KeyWords.Add("finally");
            KeyWords.Add("static");
            KeyWords.Add("return");
            KeyWords.Add("for");
            KeyWords.Add("in");
            KeyWords.Add("delegate");
            KeyWords.Add("readonly");

            //KeyWords.Add("foreach");
            Langs["nil"] = this;
            Language = "NIL isn't Lua";
        }


    }

    class KittyHighLua : KittyPL {
        public KittyHighLua() {
            // Not complete yet, but for now this will do!
            KeyWords.Add("local");
            KeyWords.Add("end");
            KeyWords.Add("function");
            KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("elseif");
            KeyWords.Add("do");
            KeyWords.Add("while");
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("return");
            KeyWords.Add("for");
            KeyWords.Add("in");
            //KeyWords.Add("foreach");
            Langs["lua"] = this;
            Language = "Lua";
            singcomment = "--";
            mulcomment = true;
            mulcommentstart = "--[[";
            mulcommentend = "]]";
        }

    }
}
