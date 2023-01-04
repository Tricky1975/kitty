// Lic:
// High/KittyHighScyndi.cs
// Kitty
// version: 23.01.04
// Copyright (C) 2019 Jeroen P. Broks
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
            // Base Types
            BaseTypes.Add("void");
            BaseTypes.Add("string");
            BaseTypes.Add("int");
            BaseTypes.Add("bool");
            BaseTypes.Add("var");
            BaseTypes.Add("plua");
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
            KeyWords.Add("quickmeta");
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
            KeyWords.Add("with");
            KeyWords.Add("const");

            KeyWords.Add("constructor");
            KeyWords.Add("destructor");
            KeyWords.Add("infinity");
            KeyWords.Add("defer");

            KeyWords.Add("import");
            KeyWords.Add("export");

            KeyWords.Add("module");

            //KeyWords.Add("foreach");
            Langs["scyndi"] = this;
            Language = "Scyndi";
        }
    }
}