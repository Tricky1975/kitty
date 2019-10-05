// Lic:
// High/KittyHighScyndi.cs
// Kitty
// version: 19.10.05
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighScyndi : KittyPL {

        public KittyHighScyndi() {
            caseinsensitive = true;
            mulcomment = true;
            mulcommentstart = "{";
            mulcommentend = "}";
            Langs["scf"] = this;
            Langs["ssf"] = this;
            Language = "Scyndi";
            KeyWords.Add("and");
            KeyWords.Add("purecode");
            KeyWords.Add("endpurecode");
            KeyWords.Add("begin");
            KeyWords.Add("break");
            KeyWords.Add("case");
            KeyWords.Add("select");
            KeyWords.Add("switch");
            KeyWords.Add("default");
            KeyWords.Add("const");
            KeyWords.Add("do");
            KeyWords.Add("else");
            KeyWords.Add("end");
            KeyWords.Add("false");
            KeyWords.Add("foru");
            KeyWords.Add("for");
            KeyWords.Add("function");
            KeyWords.Add("func");
            KeyWords.Add("def");
            KeyWords.Add("if");
            KeyWords.Add("mod");
            KeyWords.Add("nil");
            KeyWords.Add("null");
            KeyWords.Add("not");
            KeyWords.Add("procedure");
            KeyWords.Add("proc");
            KeyWords.Add("void");
            KeyWords.Add("program");
            KeyWords.Add("module");
            KeyWords.Add("script");
            KeyWords.Add("repeat");
            KeyWords.Add("shl");
            KeyWords.Add("shr");
            KeyWords.Add("string");
            KeyWords.Add("true");
            KeyWords.Add("class");
            KeyWords.Add("until");
            KeyWords.Add("use");
            KeyWords.Add("var");
            KeyWords.Add("while");
            KeyWords.Add("with"); // Done just in case, as I want to suppor this!
            KeyWords.Add("xor");


            KeyWords.Add("class");
            KeyWords.Add("catch"); //KeyWords.Add("except"); // planned
            KeyWords.Add("return");
            KeyWords.Add("finally"); // planned, but not sure yet!

            KeyWords.Add("new"); // planned
            KeyWords.Add("self"); // planned
            KeyWords.Add("try"); // planned


            KeyWords.Add("abstract"); // planned
            KeyWords.Add("default");

            KeyWords.Add("private");
            KeyWords.Add("public");
            KeyWords.Add("elseif");
            KeyWords.Add("elif");
        }

    }
}





