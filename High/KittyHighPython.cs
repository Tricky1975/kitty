// Lic:
// High/KittyHighPython.cs
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
    class KittyHighPython : KittyPL {

        public KittyHighPython() {
            KeyWords.Add("False");
            KeyWords.Add("class");
            KeyWords.Add("finally");
            KeyWords.Add("is");
            KeyWords.Add("return");
            KeyWords.Add("None");
            KeyWords.Add("continue");
            KeyWords.Add("for");
            KeyWords.Add("lambda");
            KeyWords.Add("try");
            KeyWords.Add("True");
            KeyWords.Add("def");
            KeyWords.Add("from");
            KeyWords.Add("nonlocal");
            KeyWords.Add("while");
            KeyWords.Add("and");
            KeyWords.Add("del");
            KeyWords.Add("global");
            KeyWords.Add("not");
            KeyWords.Add("with");
            KeyWords.Add("as");
            KeyWords.Add("elif");
            KeyWords.Add("if");
            KeyWords.Add("or");
            KeyWords.Add("yield");
            KeyWords.Add("assert");
            KeyWords.Add("else");
            KeyWords.Add("import");
            KeyWords.Add("pass");
            KeyWords.Add("break");
            KeyWords.Add("except");
            KeyWords.Add("in");
            KeyWords.Add("raise");
            mulcomment = false;
            singcomment = "#";
            Language = "Python";
            Langs["py"] = this;
            StringDelimiters.Add(new StringDelimiterPair("\"", "\""));
            StringDelimiters.Add(new StringDelimiterPair("'", "'"));
        }
    }
}



