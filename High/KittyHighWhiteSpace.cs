using System;

namespace Kitty {
    class KittyHighWhiteSpace:KittyHigh {
        public KittyHighWhiteSpace() {
            Language = "Whitespace";
            Langs["ws"] = this;
        }

        public override void Show(string src, bool linenumbers = false) {
            src = src.Replace("\r\n", "\n");
            var lines = src.Split('\n');
            //Console.WriteLine($"SOURCE>{lines.Length}/{lines[0]}");
            for (int i = 0; i < lines.Length; i++) {
                if (linenumbers) LineNumber(i + 1);
                for (int p = 0; p < lines[i].Length; p++) {
                    switch (lines[i][p]) {
                        case ' ': Console.BackgroundColor = KittyColors.KeyWord; break;
                        case '\t': Console.BackgroundColor = KittyColors.Identifier; break;
                        default:
                            Console.ResetColor();
                            Console.ForegroundColor = KittyColors.Comment;
                            break;
                    }
                    Console.Write(lines[i][p]);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }

}

    

