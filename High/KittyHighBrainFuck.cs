using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine();
            }
        }
    }
}
