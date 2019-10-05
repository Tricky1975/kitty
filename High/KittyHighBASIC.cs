// Lic:
// High/KittyHighBASIC.cs
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
    class KittyHighBASIC:KittyPL {
        // Please note that there ain't a programming language in the world
        // with more variants than BASIC, and fortunately most of them use their 
        // own extensions, but not all of them do and just resort to .bas
        // For Kitty I've decided to limit myself to QBASIC and GW-BASIC
        // That means that any other language using .bas is just having bad 
        // luck, and pull requests will have to be rejected by default.

        // The BASIC code I used to test this was NIBBLES.BAS
        // Since that is a game written to demonstrate QBASIC the way it originally
        // was, it was the perfect code for me to see if all stuff was covered.

        public KittyHighBASIC() {
            Language = "Beginners Allpurpose Symbolic Instruction Code (BASIC)";
            Langs["bas"] = this;
            singcomment = "'";
            mulcomment = false;
            caseinsensitive = true;
            KeyWords.Add("if");
            KeyWords.Add("else");
            KeyWords.Add("elseif");
            KeyWords.Add("then");
            KeyWords.Add("endif");
            KeyWords.Add("while");
            KeyWords.Add("wend");
            KeyWords.Add("for");
            KeyWords.Add("to");
            KeyWords.Add("step");
            KeyWords.Add("next");
            KeyWords.Add("do");
            KeyWords.Add("loop");
            KeyWords.Add("until");
            KeyWords.Add("function");
            KeyWords.Add("sub");
            KeyWords.Add("end");
            KeyWords.Add("dim");
            KeyWords.Add("def");
            KeyWords.Add("as");
            KeyWords.Add("redim");
            KeyWords.Add("type");
            KeyWords.Add("select");
            KeyWords.Add("case");
            KeyWords.Add("declare");

        }
    }
}

