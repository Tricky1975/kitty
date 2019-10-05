// Lic:
// Program.cs
// Kitty - Glue code to create an executable :P
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrickyUnits;

namespace Kitty {
    class Program {
        static void Main(string[] args) {
            // Header
            QCol.Red("Kitty "); QCol.Magenta("Coded by: Tricky\n");
            QCol.Yellow($"(c) {MKL.CYear(2019)} Jeroen P. Broks\n\n");
            // Init
            Dirry.InitAltDrives();
            KittyHigh.Init();
            new KittyHighCS();
            new KittyHighNIL();
            new KittyHighLua();
            new KittyHighGINI();
            new KittyHighScyndi();
            new KittyBlitzMax();
            new KittyHighC();
            new KittyHighPascal();
            new KittyHighBrainFuck();
            new KittyHighGo();
            new KittyHighBlitzBasic();
            new KittyHighSASKIA();
            new KittyHighPython();
            new KittyHighJavaScript();
            new KittyHighWhiteSpace();
            new KittyHighBASIC();
            var slin = true;
            // Go for it
            foreach(string a in args) {
                if (qstr.Prefixed(a, "-")) {
                    switch (a.ToLower()) {
                        case "-ln": slin = !slin; break;
                        case "-nolinenumbers": slin = false; break;
                        case "-showlinenumbers":slin = true; break;
                        default: QCol.QuickError($"Unknown switch: {a}"); break;
                    }
                } else {
                    try {
                        var arg = Dirry.AD(a).Replace("\\", "/");
                        QCol.Doing("Reading", arg);
                        var src = QuickStream.LoadString(arg);
                        var eoln = qstr.EOLNType(arg);
                        QCol.Doing("EOLN", eoln);
                        //QCol.OriCol();
                        var ext = qstr.ExtractExt(arg).ToLower();
                        KittyHigh Viewer = KittyHigh.Langs["OTHER"];
                        if (KittyHigh.Langs.ContainsKey(ext)) Viewer = KittyHigh.Langs[ext];
                        QCol.Doing("Type", Viewer.Language);
                        Console.WriteLine();
                        Viewer.Show(src, slin);

                    } catch (Exception ex) {
                        QCol.QuickError($"{ex.Message}\n");
#if DEBUG
                        QCol.Magenta($"{ex.StackTrace}\n\n");
#endif
                    }
                }
            }
            TrickyDebug.AttachWait();
        }
    }
}







