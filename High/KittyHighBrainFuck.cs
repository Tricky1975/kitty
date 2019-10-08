// Lic:
// High/KittyHighBrainFuck.cs
// Kitty
// version: 19.10.08
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

using System;

namespace Kitty {
    class KittyHighBrainFuck : KittyHigh {
        public KittyHighBrainFuck() {
            Language = "BrainFuck";
            Langs["bf"] = this;
        }

        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');
            //Console.WriteLine($"SOURCE>{lines.Length}/{lines[0]}");
            for (int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1);
                for (int p = 0; p < lines[i].Length; p++) {
                    switch (lines[i][p]) {
                        case '+':
                        case '-':
                            Console.ForegroundColor = KittyColors.Number;
                            break;
                        case '.':
                        case ',':
                            Console.ForegroundColor = KittyColors.String;
                            break;
                        case '<':
                        case '>':
                            Console.ForegroundColor = KittyColors.Identifier;
                            break;
                        case '[':
                        case ']':
                            Console.ForegroundColor = KittyColors.KeyWord;
                            break;
                        default:
                            Console.ForegroundColor = KittyColors.Comment;
                            break;
                    }
                    Console.Write(lines[i][p]);
                }
                WriteLine();
            }
        }
    }
}





