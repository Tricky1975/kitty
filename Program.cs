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
            new KittyBlitzMax();
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
