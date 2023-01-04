// Lic:
// High/KittyHighSASKIA.cs
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

namespace Kitty {
    class KittyHighSASKIA:KittyPL {



        public KittyHighSASKIA() {
            // Not complete yet, but for now this will do!
            caseinsensitive = true;
            singcomment = ";";
            mulcomment = false;


            Langs["saskia"] = this;
            Language = "Serial Adventure Scripting Keeping Interface Advancements (SASKIA)";

            KeyWords.Add("call");
            KeyWords.Add("jmp");
            KeyWords.Add("chk");
            KeyWords.Add("mov");
            KeyWords.Add("end");
            KeyWords.Add("group");
            KeyWords.Add("return");
            KeyWords.Add("gosub");
        }

        
    }






}