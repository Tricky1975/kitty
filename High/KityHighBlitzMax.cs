
namespace Kitty {
    class KittyBlitzMax : KittyPL {

        public KittyBlitzMax() {
            // Not complete yet, but for now this will do!
            caseinsensitive = true;
            singcomment = "'";
            KeyWords.Add("import");
            KeyWords.Add("module");
            KeyWords.Add("type");
            KeyWords.Add("moduleinfo");
            KeyWords.Add("public");
            KeyWords.Add("private");
            KeyWords.Add("extends");
            KeyWords.Add("method");
            KeyWords.Add("function");
            KeyWords.Add("string");
            KeyWords.Add("int");
            KeyWords.Add("byte");
            KeyWords.Add("long");
            KeyWords.Add("select");
            KeyWords.Add("case");
            KeyWords.Add("default");
            KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("elseif");
            KeyWords.Add("then");
            KeyWords.Add("while");
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("abstract");
            KeyWords.Add("self");
            KeyWords.Add("try");
            KeyWords.Add("catch");
            KeyWords.Add("finally");
            KeyWords.Add("local");
            KeyWords.Add("global");
            KeyWords.Add("return");
            KeyWords.Add("for");
            KeyWords.Add("eachin");
            KeyWords.Add("new");
            KeyWords.Add("delete");
            KeyWords.Add("break");
            KeyWords.Add("null");
            KeyWords.Add("field");
            KeyWords.Add("include");
            KeyWords.Add("incbin");
            KeyWords.Add("framework");
            KeyWords.Add("strict");
            KeyWords.Add("superstrict");
            KeyWords.Add("const");

            KeyWords.Add("rem"); // Although I must set some things right here...

            // Endings
            KeyWords.Add("end");
            KeyWords.Add("endif");
            KeyWords.Add("endfunction");
            KeyWords.Add("endmethod");
            KeyWords.Add("endtype");
            KeyWords.Add("endrem");
            KeyWords.Add("wend");
            KeyWords.Add("next");

            Langs["bmx"] = this;
            Language = "BlitzMax";
        }

    }
}
