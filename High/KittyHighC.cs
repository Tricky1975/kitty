// Lic:
// High/KittyHighC.cs
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
    class KittyHighC : KittyPL {

        public KittyHighC() {

            Langs["c"] = this;
            Langs["cpp"] = this;
            Langs["h"] = this;
            Langs["hpp"] = this;
            Language = "C/C++";
            KeyWords.Add("asm");
            KeyWords.Add("else");
            KeyWords.Add("new");
            KeyWords.Add("this");
            KeyWords.Add("auto");
            KeyWords.Add("enum");
            KeyWords.Add("operator");
            KeyWords.Add("throw");
            KeyWords.Add("bool");
            KeyWords.Add("explicit");
            KeyWords.Add("private");
            KeyWords.Add("true");
            KeyWords.Add("break");
            KeyWords.Add("export");
            KeyWords.Add("protected");
            KeyWords.Add("try");
            KeyWords.Add("case");
            KeyWords.Add("extern");
            KeyWords.Add("public");
            KeyWords.Add("typedef");
            KeyWords.Add("catch");
            KeyWords.Add("false");
            KeyWords.Add("register");
            KeyWords.Add("typeid");
            KeyWords.Add("char");
            KeyWords.Add("float");
            KeyWords.Add("reinterpret_cast");
            KeyWords.Add("typename");
            KeyWords.Add("class");
            KeyWords.Add("for");
            KeyWords.Add("return");
            KeyWords.Add("union");
            KeyWords.Add("const");
            KeyWords.Add("friend");
            KeyWords.Add("short");
            KeyWords.Add("unsigned");
            KeyWords.Add("const_cast");
            KeyWords.Add("goto");
            KeyWords.Add("signed");
            KeyWords.Add("using");
            KeyWords.Add("continue");
            KeyWords.Add("if");
            KeyWords.Add("sizeof");
            KeyWords.Add("virtual");
            KeyWords.Add("default");
            KeyWords.Add("inline");
            KeyWords.Add("static");
            KeyWords.Add("void");
            KeyWords.Add("delete");
            KeyWords.Add("int");
            KeyWords.Add("static_cast");
            KeyWords.Add("volatile");
            KeyWords.Add("do");
            KeyWords.Add("long");
            KeyWords.Add("struct");
            KeyWords.Add("wchar_t");
            KeyWords.Add("double");
            KeyWords.Add("mutable");
            KeyWords.Add("switch");
            KeyWords.Add("while");
            KeyWords.Add("dynamic_cast");
            KeyWords.Add("namespace");
            KeyWords.Add("template");
        }

    }
}


