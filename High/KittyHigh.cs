using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty {
    abstract class KittyHigh {
        public abstract void Show(string src);
        public void Show(StringBuilder src) => Show(src);
    }


    class KittyPL:KittyHigh {
        protected List<string> KeyWords;
    }
}
