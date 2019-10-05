// Lic:
// High/KittyHighJava.cs
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

namespace Kitty {
    class KittyHighJava:KittyPL {

        public KittyHighJava() {
            // Since I never worked with Java this has NOT been tested, so I really won't know if this works.
            // Since Java is just one of the many C dialects out there, I don't see why it won't but, who am I to talk?
            KeyWords.Add("abstract");
            KeyWords.Add("assert");
            KeyWords.Add("boolean");
            KeyWords.Add("break");
            KeyWords.Add("byte");
            KeyWords.Add("case");
            KeyWords.Add("catch");
            KeyWords.Add("char");
            KeyWords.Add("class");
            KeyWords.Add("continue");
            KeyWords.Add("const");
            KeyWords.Add("default");
            KeyWords.Add("do");
            KeyWords.Add("double");
            KeyWords.Add("else");
            KeyWords.Add("enum");
            KeyWords.Add("exports");
            KeyWords.Add("extends");
            KeyWords.Add("final");
            KeyWords.Add("finally");
            KeyWords.Add("float");
            KeyWords.Add("for");
            KeyWords.Add("goto");
            KeyWords.Add("if");
            KeyWords.Add("implements");
            KeyWords.Add("import");
            KeyWords.Add("instanceof");
            KeyWords.Add("int");
            KeyWords.Add("interface");
            KeyWords.Add("long");
            KeyWords.Add("module");
            KeyWords.Add("native");
            KeyWords.Add("new");
            KeyWords.Add("package");
            KeyWords.Add("private");
            KeyWords.Add("protected");
            KeyWords.Add("public");
            KeyWords.Add("requires");
            KeyWords.Add("return");
            KeyWords.Add("short");
            KeyWords.Add("static");
            KeyWords.Add("strictfp");
            KeyWords.Add("super");
            KeyWords.Add("switch");
            KeyWords.Add("synchronized");
            KeyWords.Add("this");
            KeyWords.Add("throw");
            KeyWords.Add("throws");
            KeyWords.Add("transient");
            KeyWords.Add("try");
            KeyWords.Add("var");
            KeyWords.Add("void");
            KeyWords.Add("volatile");
            KeyWords.Add("while");
            Language = "Java";
            Langs["java"] = this;
        }
    }
}

