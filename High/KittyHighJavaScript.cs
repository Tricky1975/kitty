// Lic:
// High/KittyHighJavaScript.cs
// Kitty
// version: 19.10.04
// Copyright (C)  Jeroen P. Broks
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

namespace Kitty {
    class KittyHighJavaScript:KittyPL {

        public KittyHighJavaScript() {
            // JavaScript is due to it's lack of thinking things true from the start, cursed with more changes in a short time
            // than any other programming lanuage I can think of. I hope this list is up-to-date, and I know some keywords have been removed, but 
            // I cannot care less, as keeping this up to date is undoable.
            KeyWords.Add("abstract");
            KeyWords.Add("arguments");
            KeyWords.Add("await");
            KeyWords.Add("boolean");
            KeyWords.Add("break");
            KeyWords.Add("byte");
            KeyWords.Add("case");
            KeyWords.Add("catch");
            KeyWords.Add("char");
            KeyWords.Add("class");
            KeyWords.Add("const");
            KeyWords.Add("continue");
            KeyWords.Add("debugger");
            KeyWords.Add("default");
            KeyWords.Add("delete");
            KeyWords.Add("do");
            KeyWords.Add("double");
            KeyWords.Add("else");
            KeyWords.Add("enum");
            KeyWords.Add("eval");
            KeyWords.Add("export");
            KeyWords.Add("extends");
            KeyWords.Add("false");
            KeyWords.Add("final");
            KeyWords.Add("finally");
            KeyWords.Add("float");
            KeyWords.Add("for");
            KeyWords.Add("function");
            KeyWords.Add("goto");
            KeyWords.Add("if");
            KeyWords.Add("implements");
            KeyWords.Add("import");
            KeyWords.Add("in");
            KeyWords.Add("instanceof");
            KeyWords.Add("int");
            KeyWords.Add("interface");
            KeyWords.Add("let");
            KeyWords.Add("long");
            KeyWords.Add("native");
            KeyWords.Add("new");
            KeyWords.Add("null");
            KeyWords.Add("package");
            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("public");
            KeyWords.Add("return");
            KeyWords.Add("short");
            KeyWords.Add("static");
            KeyWords.Add("super");
            KeyWords.Add("switch");
            KeyWords.Add("synchronized");
            KeyWords.Add("this");
            KeyWords.Add("throw");
            KeyWords.Add("throws");
            KeyWords.Add("transient");
            KeyWords.Add("true");
            KeyWords.Add("try");
            KeyWords.Add("typeof");
            KeyWords.Add("var");
            KeyWords.Add("void");
            KeyWords.Add("volatile");
            KeyWords.Add("while");
            KeyWords.Add("with");
            KeyWords.Add("yield");
            Language = "JavaScript";
            Langs["js"] = this;
            new KittyHighJSON();
            StringDelimiters.Add(new StringDelimiterPair("\"", "\""));
            StringDelimiters.Add(new StringDelimiterPair("'", "'"));
        }
    }

    class KittyHighJSON : KittyPL {
        public KittyHighJSON() {            
            supcom = false;
            Language = "JSON";
            Langs["json"] = this;
            KeyWords.Add("true");
            KeyWords.Add("false");
            KeyWords.Add("null");
        }
    }
}


