// Lic:
// High/KittyHighBlitzBasic.cs
// Kitty
// version: 20.08.15
// Copyright (C) Kitty Jeroen P. Broks
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
    class KittyHighBlitzBasic : KittyPL {



        public KittyHighBlitzBasic() {
            // Not complete yet, but for now this will do!
            caseinsensitive = true;
            singcomment = ";";
            escape = '\0';
            mulcomment = false;

            BaseTypes.Add("string");
            BaseTypes.Add("int");
            BaseTypes.Add("byte"); // ?
            BaseTypes.Add("long");

            //KeyWords.Add("import");
            //KeyWords.Add("module");
            KeyWords.Add("type");
            //KeyWords.Add("moduleinfo");
            //KeyWords.Add("public");
            //KeyWords.Add("private");
            //KeyWords.Add("extends");
            KeyWords.Add("method"); // ?
            KeyWords.Add("function");
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
            //KeyWords.Add("abstract");
            KeyWords.Add("self");
            KeyWords.Add("try"); // ?
            KeyWords.Add("catch"); // ?
            KeyWords.Add("finally"); // ?
            KeyWords.Add("local");
            KeyWords.Add("global");
            KeyWords.Add("return");
            KeyWords.Add("for");
            KeyWords.Add("each");
            KeyWords.Add("new");
            KeyWords.Add("delete");
            KeyWords.Add("break");
            //KeyWords.Add("null");
            KeyWords.Add("field");
            KeyWords.Add("include");
            //KeyWords.Add("incbin");
            //KeyWords.Add("framework");
            //KeyWords.Add("strict");
            //KeyWords.Add("superstrict");
            KeyWords.Add("const");
            KeyWords.Add("not");
            KeyWords.Add("data");
            KeyWords.Add("dim");
            KeyWords.Add("repeat");

            KeyWords.Add("end");
            KeyWords.Add("endif");
            KeyWords.Add("endfunction");
            KeyWords.Add("endmethod");
            KeyWords.Add("endtype");
            KeyWords.Add("endrem");
            KeyWords.Add("wend");
            KeyWords.Add("next");
            KeyWords.Add("until");
            KeyWords.Add("forever");

        Langs["bb"] = this;
            Language = "BlitzBasic / Blitz3D / BlitzPlus";
        }

    }
}