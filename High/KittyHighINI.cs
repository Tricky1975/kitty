// Lic:
// High/KittyHighINI.cs
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

using System;

namespace Kitty {
    class KittyHighINI:KittyHigh {
        public KittyHighINI() {
            Language = "Configuration File";
            Langs["ini"] = this;
        }

        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');            
            //WriteLine($"SOURCE>{lines.Length}/{lines[0]}");
            for (int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1); //LineNumber(i + 1);
                var line = lines[i].Trim();
                if (line == "") {
                    WriteLine();
                } else if ((line[0] == '[' || line[line.Length - 1] == ']')) {
                    if (!(line[0] == '[' && line[line.Length - 1] == ']')) {
                        Console.ForegroundColor = KittyColors.Error;
                    } else {
                        Console.ForegroundColor = KittyColors.KeyWord;
                        WriteLine(lines[i]);
                    }
                } else if (line.Trim()[0] == ';') {
                    Console.ForegroundColor = KittyColors.Comment;
                    WriteLine(lines[i]);
                } else {
                    var isteken = lines[i].IndexOf('=');
                    if (isteken <= 0) isteken = lines[i].IndexOf(':');
                    if (isteken <= 0) {
                        Console.ForegroundColor = KittyColors.Error; WriteLine(lines[i]);
                    } else {
                        Console.ForegroundColor = KittyColors.Identifier;
                        Console.Write(lines[i].Substring(0, isteken));
                        Console.ForegroundColor = KittyColors.Other;
                        Console.Write(lines[i][isteken]);
                        Console.ForegroundColor = KittyColors.String;
                        WriteLine(lines[i].Substring(isteken + 1));
                    }
                }
                
            }
        }
    }
}



