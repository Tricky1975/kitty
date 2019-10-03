using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighCS:KittyPL {

        public KittyHighCS() {
            // Not complete yet, but for now this will do!
            KeyWords.Add("using");
            KeyWords.Add("namespace");
            KeyWords.Add("class");
            KeyWords.Add("struct");
            KeyWords.Add("public");
            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("internal");            
            KeyWords.Add("void");
            KeyWords.Add("string");
            KeyWords.Add("int");
            KeyWords.Add("bool");
            KeyWords.Add("switch");
            KeyWords.Add("case");
            KeyWords.Add("default");
            KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("do");
            KeyWords.Add("while");
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("abstract");
            KeyWords.Add("override");
            KeyWords.Add("this");
            KeyWords.Add("get");
            KeyWords.Add("set");
            Langs["cs"] = this;
            Language = "C#";
        }

    }
}
