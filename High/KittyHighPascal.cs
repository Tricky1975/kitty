// Lic:
// High/KittyHighPascal.cs
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
    class KittyHighPascal : KittyPL {

        public KittyHighPascal() {
            // Please note, that I tried to cover Pascal, Turbo Pascal and Object Pascal (and in the process Free Pascal) all in one go, so some keywords may not be keywords in all Pascal compilers.
            caseinsensitive = true;
            mulcomment = true;
            mulcommentstart = "{";
            mulcommentend = "}";
            Langs["pas"] = this;
            Language = "Pascal";
            KeyWords.Add("and");
            KeyWords.Add("array");
            KeyWords.Add("asm");
            KeyWords.Add("begin");
            KeyWords.Add("break");
            KeyWords.Add("case");
            KeyWords.Add("const");
            KeyWords.Add("constructor");
            KeyWords.Add("continue");
            KeyWords.Add("destructor");
            KeyWords.Add("div");
            KeyWords.Add("do");
            KeyWords.Add("downto");
            KeyWords.Add("else");
            KeyWords.Add("end");
            KeyWords.Add("false");
            KeyWords.Add("file");
            KeyWords.Add("for");
            KeyWords.Add("function");
            KeyWords.Add("goto");
            KeyWords.Add("if");
            KeyWords.Add("implementation");
            KeyWords.Add("in");
            KeyWords.Add("inline");
            KeyWords.Add("interface");
            KeyWords.Add("label");
            KeyWords.Add("mod");
            KeyWords.Add("nil");
            KeyWords.Add("not");
            KeyWords.Add("object");
            KeyWords.Add("of");
            KeyWords.Add("operator");
            KeyWords.Add("packed");
            KeyWords.Add("procedure");
            KeyWords.Add("program");
            KeyWords.Add("record");
            KeyWords.Add("repeat");
            KeyWords.Add("set");
            KeyWords.Add("shl");
            KeyWords.Add("shr");
            KeyWords.Add("string");
            KeyWords.Add("then");
            KeyWords.Add("to");
            KeyWords.Add("true");
            KeyWords.Add("type");
            KeyWords.Add("unit");
            KeyWords.Add("until");
            KeyWords.Add("uses");
            KeyWords.Add("var");
            KeyWords.Add("while");
            KeyWords.Add("with");
            KeyWords.Add("xor");

            KeyWords.Add("Object");

            KeyWords.Add("as");
            KeyWords.Add("class");
            KeyWords.Add("dispose");
            KeyWords.Add("except");
            KeyWords.Add("exit");
            KeyWords.Add("exports");
            KeyWords.Add("finalization");
            KeyWords.Add("finally");

            KeyWords.Add("initialization");
            KeyWords.Add("is");
            KeyWords.Add("library");
            KeyWords.Add("new");
            KeyWords.Add("on");
            KeyWords.Add("out");
            KeyWords.Add("property");
            KeyWords.Add("raise");
            KeyWords.Add("self");
            KeyWords.Add("threadvar");
            KeyWords.Add("try");


            KeyWords.Add("absolute");
            KeyWords.Add("abstract");
            KeyWords.Add("alias");
            KeyWords.Add("assembler");
            KeyWords.Add("cdecl");
            KeyWords.Add("cppdecl");
            KeyWords.Add("default");
            KeyWords.Add("export");
            KeyWords.Add("external");
            KeyWords.Add("forward");
            KeyWords.Add("generic");
            KeyWords.Add("index");
            KeyWords.Add("local");
            KeyWords.Add("name");
            KeyWords.Add("nostackframe");
            KeyWords.Add("oldfpccall");
            KeyWords.Add("override");

            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("public");
            KeyWords.Add("published");
            KeyWords.Add("read");
            KeyWords.Add("register");
            KeyWords.Add("reintroduce");
            KeyWords.Add("safecall");
            KeyWords.Add("softfloat");
            KeyWords.Add("specialize");

            KeyWords.Add("stdcall");
            KeyWords.Add("virtual");
            KeyWords.Add("write");


            KeyWords.Add("far");
            KeyWords.Add("near");
        }

    }
}


