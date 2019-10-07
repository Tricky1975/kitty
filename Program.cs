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
            new KittyHighJava();
            new KittyHighINI();
            var slin = true;
            if (args.Length == 0) {
                QCol.Green("Kitty is a simple program which will help you view source files in syntax highlight\n");
                QCol.Magenta("Usage:\t");
                QCol.Yellow("Kitty ");
                QCol.Cyan("<switches> ");
                QCol.White("<files>");
                QCol.Green("[");
                QCol.Cyan("<switches> ");
                QCol.White("<files>");
                QCol.Green("..]");
                Console.WriteLine("\n\n");
                QCol.Yellow("Please note that switches affect all files defined after it not those that come before it. This allows you to configure each file shown\n\n");
                QCol.Cyan("-ln              "); QCol.Yellow("Toggle line numbers on/off (default is on)\n");
                QCol.Cyan("-nolinenumbers   "); QCol.Yellow("Turn line numbers off\n");
                QCol.Cyan("-Showlinenumbers "); QCol.Yellow("Turn line numbers on\n");
                QCol.Cyan("-p, -more        "); QCol.Yellow("Turn \"more\" mode on/off. (Read note below)\n");
                QCol.Red("The \"more\" mode!\n");
                QCol.Yellow("Does not entirely work the same as the 'more' utility, but has the same primary function!\n");
                QCol.Yellow("When the \"more\" bar appears you can hit space to show the next line, Enter/Return to show the entire next page and escape to turn the more mode off\n");
                QCol.White("\n\nKitty can be used as as CLI tool, but the integry has been made to be included in your own projects, and has been released under the terms of the zlib license\n\n");
                return;
            }
            // Go for it
            foreach (string a in args) {
                if (qstr.Prefixed(a, "-")) {
                    switch (a.ToLower()) {
                        case "-ln": slin = !slin; break;
                        case "-nolinenumbers": slin = false; break;
                        case "-showlinenumbers":slin = true; break;
                        case "-p": case "-more": KittyHigh.BrkLines = !KittyHigh.BrkLines; break;
                        default: QCol.QuickError($"Unknown switch: {a}"); break;
                    }
                } else {
                    try {
                        var arg = Dirry.AD(a).Replace("\\", "/");
                        QCol.Doing("Reading", arg); KittyHigh.PageBreak();
                        var src = QuickStream.LoadString(arg);
                        var eoln = qstr.EOLNType(arg);
                        // QCol.Doing("EOLN", eoln); // didn't work anyway
                        //QCol.OriCol();
                        var ext = qstr.ExtractExt(arg).ToLower();
                        KittyHigh Viewer = KittyHigh.Langs["OTHER"];
                        if (KittyHigh.Langs.ContainsKey(ext)) Viewer = KittyHigh.Langs[ext];
                        QCol.Doing("Type", Viewer.Language); KittyHigh.PageBreak();
                        KittyHigh.WriteLine();
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









