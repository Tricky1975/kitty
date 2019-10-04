using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kitty {
    class KittyHighGo : KittyPL {

        public KittyHighGo() {

            Langs["go"] = this;
            Language = "Go";
            KeyWords.Add("break");
            KeyWords.Add("default");
            KeyWords.Add("func");
            KeyWords.Add("interface");
            KeyWords.Add("select");
            KeyWords.Add("case");
            KeyWords.Add("defer");
            KeyWords.Add("go");
            KeyWords.Add("map");
            KeyWords.Add("struct");
            KeyWords.Add("chan");
            KeyWords.Add("else");
            KeyWords.Add("goto");
            KeyWords.Add("package");
            KeyWords.Add("switch");
            KeyWords.Add("const");
            KeyWords.Add("fallthrough");
            KeyWords.Add("if");
            KeyWords.Add("range");
            KeyWords.Add("type");
            KeyWords.Add("continue");
            KeyWords.Add("for");
            KeyWords.Add("import");
            KeyWords.Add("return");
            KeyWords.Add("var");
        }

    }
}



