// Lic:
// High/KittyHighGo.cs
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





