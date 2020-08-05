using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighNeil : KittyPL {
        public KittyHighNeil() {
            caseinsensitive = true;
            // Not complete yet, but for now this will do!
            KeyWords.Add("not");
            KeyWords.Add("class");
            KeyWords.Add("group");
            KeyWords.Add("module");
            KeyWords.Add("global");
            KeyWords.Add("private");
            KeyWords.Add("end");
            KeyWords.Add("and");
            KeyWords.Add("or");
            KeyWords.Add("table");
            KeyWords.Add("void");
            KeyWords.Add("string");
            KeyWords.Add("int");
            KeyWords.Add("quickmeta");
            KeyWords.Add("bool");
            KeyWords.Add("var");
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
            KeyWords.Add("new");
            KeyWords.Add("break");
            KeyWords.Add("nil");
            KeyWords.Add("extends");

            KeyWords.Add("repeat");
            KeyWords.Add("until");
            KeyWords.Add("loopwhile");
            KeyWords.Add("init");
            KeyWords.Add("cfor");
            KeyWords.Add("pairs");
            KeyWords.Add("ipairs");

            KeyWords.Add("constructor");
            KeyWords.Add("destructor");
            KeyWords.Add("infinity");

            //KeyWords.Add("foreach");
            Langs["neil"] = this;
            Language = "Neil";
        }
    }
}
