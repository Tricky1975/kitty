// Lic:
// High/KittyHighCS.cs
// Kitty
// version: 20.10.22
// Copyright (C) 2019, 2020 Jeroen P. Broks
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
    class KittyHighCS:KittyPL {

        public KittyHighCS() {
            // Not complete yet, but for now this will do!
            BaseTypes.Add("bool");
            BaseTypes.Add("byte");
            BaseTypes.Add("sbyte");
            BaseTypes.Add("char");
            BaseTypes.Add("decimal");
            BaseTypes.Add("double");
            BaseTypes.Add("float");
            BaseTypes.Add("int");
            BaseTypes.Add("uint");
            BaseTypes.Add("long");
            BaseTypes.Add("ulong");
            BaseTypes.Add("short");
            BaseTypes.Add("ushort");
            KeyWords.Add("abstract");
            KeyWords.Add("as");
            KeyWords.Add("base");
            KeyWords.Add("break");
            KeyWords.Add("case");
            KeyWords.Add("catch");
            KeyWords.Add("checked");
            KeyWords.Add("class");
            KeyWords.Add("const");
            KeyWords.Add("continue");
            KeyWords.Add("default");
            KeyWords.Add("delegate");
            KeyWords.Add("do");
            KeyWords.Add("else");
            KeyWords.Add("enum");
            KeyWords.Add("event");
            KeyWords.Add("explicit");
            KeyWords.Add("extern");
            KeyWords.Add("false");
            KeyWords.Add("finally");
            KeyWords.Add("fixed");
            KeyWords.Add("for");
            KeyWords.Add("foreach");
            KeyWords.Add("goto"); // EEEEW!
            KeyWords.Add("if");
            KeyWords.Add("implicit");
            KeyWords.Add("in");
            KeyWords.Add("interface");
            KeyWords.Add("internal");
            KeyWords.Add("is");
            KeyWords.Add("lock");
            KeyWords.Add("namespace");
            KeyWords.Add("new");
            KeyWords.Add("null");
            KeyWords.Add("object");
            KeyWords.Add("operator");
            KeyWords.Add("out");
            KeyWords.Add("override");
            KeyWords.Add("params");
            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("public");
            KeyWords.Add("readonly");
            KeyWords.Add("ref");
            KeyWords.Add("return");
            KeyWords.Add("sealed");
            KeyWords.Add("sizeof");
            KeyWords.Add("stackalloc");
            KeyWords.Add("static");
            KeyWords.Add("string");
            KeyWords.Add("struct");
            KeyWords.Add("switch");
            KeyWords.Add("this");
            KeyWords.Add("throw");
            KeyWords.Add("true");
            KeyWords.Add("try");
            KeyWords.Add("typeof");
            KeyWords.Add("unchecked");
            KeyWords.Add("unsafe");
            KeyWords.Add("using");
            KeyWords.Add("virtual");
            KeyWords.Add("volatile");
            KeyWords.Add("while");

            // Since we've them for VB here are unreserved keywords

            KeyWords.Add("add");
            KeyWords.Add("alias");
            KeyWords.Add("ascending");
            KeyWords.Add("async");
            KeyWords.Add("await");
            KeyWords.Add("by");
            KeyWords.Add("descending");
            KeyWords.Add("dynamic");
            KeyWords.Add("equals");
            KeyWords.Add("from");
            KeyWords.Add("get");
            KeyWords.Add("global");
            KeyWords.Add("group");
            KeyWords.Add("into");
            KeyWords.Add("join");
            KeyWords.Add("let");
            KeyWords.Add("nameof");
            KeyWords.Add("notnull");
            KeyWords.Add("on");
            KeyWords.Add("oderby");
            KeyWords.Add("partial");
            KeyWords.Add("remove");
            KeyWords.Add("select");
            KeyWords.Add("set");
            KeyWords.Add("unmanaged");
            KeyWords.Add("value");
            KeyWords.Add("var");
            KeyWords.Add("void");
            KeyWords.Add("when");
            KeyWords.Add("where");
            KeyWords.Add("yield");

            Langs["cs"] = this;
            Language = "C#";
        }

    }
}