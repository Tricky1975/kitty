using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    class KittyHighGINI : KittyHigh {

        enum GINIStage  {None,List, Var, Comment };

        public KittyHighGINI() {
            KittyHigh.Langs["gini"] = this;
            Language= "GINI Is Not Ini";
        }

        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');
            var stage = GINIStage.None;
            //Console.WriteLine($"SOURCE>{lines.Length}/{lines[0]}");
            for (int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1); //LineNumber(i + 1);
                var line = lines[i].Trim();
                if (line == "") {
                    Console.WriteLine();
                } else if ((line[0] == '[' || line[line.Length - 1] == ']')) {
                    if (!(line[0] == '[' && line[line.Length - 1] == ']')) {
                        Console.ForegroundColor = KittyColors.Error;
                    } else {
                        Console.ForegroundColor = KittyColors.KeyWord;
                        if (line.Length > 6 && line.ToUpper().Substring(0, 6) == "[LIST:")
                            stage = GINIStage.List;
                        else {
                            switch (line.ToUpper()) {
                                case "[REM]":
                                case "[LIC]":
                                    stage = GINIStage.Comment;
                                    break;
                                case "[VARS]":
                                    stage = GINIStage.Var;
                                    break;
                                default:
                                    stage = GINIStage.None;
                                    break;
                            }
                        }
                        Console.WriteLine(lines[i]);
                    }
                } else {
                    switch (stage) {
                        case GINIStage.None:
                            Console.ForegroundColor = KittyColors.Error; Console.WriteLine(lines[i]); break;
                        case GINIStage.List:
                            Console.ForegroundColor = KittyColors.String; Console.WriteLine(lines[i]); break;
                        case GINIStage.Comment:
                            Console.ForegroundColor = KittyColors.Comment; Console.WriteLine(lines[i]); break;
                        case GINIStage.Var: {
                                var isteken = lines[i].IndexOf('=');
                                if (isteken <= 0) {
                                    Console.ForegroundColor = KittyColors.Error; Console.WriteLine(lines[i]);
                                } else {
                                    Console.ForegroundColor = KittyColors.Identifier;
                                    Console.Write(lines[i].Substring(0, isteken));
                                    Console.ForegroundColor = KittyColors.Other;
                                    Console.Write("=");
                                    Console.ForegroundColor = KittyColors.String;
                                    Console.WriteLine(lines[i].Substring(isteken + 1));
                                }
                                break;
                            }
                        default:
                            Console.ForegroundColor = KittyColors.Error; Console.WriteLine($"???>{lines[i]}"); break;
                    }
                }
            }
        }
    }
}
