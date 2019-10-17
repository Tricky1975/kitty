// Lic:
// High/KittyHighVB.cs
// Kitty
// version: 19.10.04
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
namespace Kitty {

    // Visual Basic support by freezernick
    class KittyHighVB : KittyPL {

        public KittyHighVB() {

            Langs["vb"] = this;
            Language = "VisualBasic";
            singcomment = "'";
            mulcomment = false;
            caseinsensitive = true;
            KeyWords.Add("addhandler");
            KeyWords.Add("addressof");
            KeyWords.Add("alias");
            KeyWords.Add("and");
            KeyWords.Add("andalso");
            KeyWords.Add("as");
            KeyWords.Add("boolean");
            KeyWords.Add("byref");
            KeyWords.Add("byte");
            KeyWords.Add("byval");
            KeyWords.Add("call");
            KeyWords.Add("case");
            KeyWords.Add("catch");
            KeyWords.Add("cbool");
            KeyWords.Add("cbyte");
            KeyWords.Add("cchar");
            KeyWords.Add("cdate");
            KeyWords.Add("cdbl");
            KeyWords.Add("cdec");
            KeyWords.Add("char");
            KeyWords.Add("cint");
            KeyWords.Add("class");
            KeyWords.Add("clng");
            KeyWords.Add("cobj");
            KeyWords.Add("const");
            KeyWords.Add("continue");
            KeyWords.Add("csbyte");
            KeyWords.Add("cshort");
            KeyWords.Add("csng");
            KeyWords.Add("cstr");
            KeyWords.Add("ctype");
            KeyWords.Add("cuint");
            KeyWords.Add("culng");
            KeyWords.Add("cushort");
            KeyWords.Add("date");
            KeyWords.Add("decimal");
            KeyWords.Add("declare");
            KeyWords.Add("default");
            KeyWords.Add("delegate");
            KeyWords.Add("dim");
            KeyWords.Add("directcast");
            KeyWords.Add("do");
            KeyWords.Add("double");
            KeyWords.Add("each");
            KeyWords.Add("else");
            KeyWords.Add("elseif");
            KeyWords.Add("end");
            KeyWords.Add("enum");
            KeyWords.Add("erase");
            KeyWords.Add("error");
            KeyWords.Add("event");
            KeyWords.Add("exit");
            KeyWords.Add("false");
            KeyWords.Add("finally");
            KeyWords.Add("for");
            KeyWords.Add("friend");
            KeyWords.Add("function");
            KeyWords.Add("get");
            KeyWords.Add("gettype");
            KeyWords.Add("getxmlnamespace");
            KeyWords.Add("global");
            KeyWords.Add("goto");
            KeyWords.Add("handles");
            KeyWords.Add("if");
            KeyWords.Add("implements");
            KeyWords.Add("imports");
            KeyWords.Add("in");
            KeyWords.Add("inherits");
            KeyWords.Add("integer");
            KeyWords.Add("interface");
            KeyWords.Add("is");
            KeyWords.Add("isnot");
            KeyWords.Add("let");
            KeyWords.Add("lib");
            KeyWords.Add("like");
            KeyWords.Add("long");
            KeyWords.Add("loop");
            KeyWords.Add("me");
            KeyWords.Add("mod");
            KeyWords.Add("module");
            KeyWords.Add("mustinherit");
            KeyWords.Add("mustoverride");
            KeyWords.Add("mybase");
            KeyWords.Add("myclass");
            KeyWords.Add("namespace");
            KeyWords.Add("narrowing");
            KeyWords.Add("new constraint");
            KeyWords.Add("new operator");
            KeyWords.Add("next");
            KeyWords.Add("not");
            KeyWords.Add("nothing");
            KeyWords.Add("noninheritable");
            KeyWords.Add("notoverridable");
            KeyWords.Add("object");
            KeyWords.Add("of");
            KeyWords.Add("on");
            KeyWords.Add("operator");
            KeyWords.Add("option");
            KeyWords.Add("optional");
            KeyWords.Add("or");
            KeyWords.Add("orelse");
            KeyWords.Add("out");
            KeyWords.Add("overloads");
            KeyWords.Add("overridable");
            KeyWords.Add("overrides");
            KeyWords.Add("paramarray");
            KeyWords.Add("partial");
            KeyWords.Add("private");
            KeyWords.Add("property");
            KeyWords.Add("protected");
            KeyWords.Add("public");
            KeyWords.Add("raiseevent");
            KeyWords.Add("readonly");
            KeyWords.Add("redim");
            KeyWords.Add("rem");
            KeyWords.Add("removehandler");
            KeyWords.Add("resume");
            KeyWords.Add("return");
            KeyWords.Add("sbyte");
            KeyWords.Add("select");
            KeyWords.Add("set");
            KeyWords.Add("shadows");
            KeyWords.Add("shared");
            KeyWords.Add("short");
            KeyWords.Add("single");
            KeyWords.Add("static");
            KeyWords.Add("step");
            KeyWords.Add("stop");
            KeyWords.Add("string");
            KeyWords.Add("structure constraint");
            KeyWords.Add("sub");
            KeyWords.Add("synclock");
            KeyWords.Add("then");
            KeyWords.Add("throw");
            KeyWords.Add("to");
            KeyWords.Add("true");
            KeyWords.Add("try");
            KeyWords.Add("trycast");
            KeyWords.Add("typeof");
            KeyWords.Add("uinteger");
            KeyWords.Add("ulong");
            KeyWords.Add("ushort");
            KeyWords.Add("using");
            KeyWords.Add("when");
            KeyWords.Add("while");
            KeyWords.Add("widening");
            KeyWords.Add("with");
            KeyWords.Add("withevents");
            KeyWords.Add("writeonly");
            KeyWords.Add("xor");

            // unreserved keywords

            KeyWords.Add("aggregate");
            KeyWords.Add("ansi");
            KeyWords.Add("assembly");
            KeyWords.Add("async");
            KeyWords.Add("auto");
            KeyWords.Add("await");
            KeyWords.Add("binary");
            KeyWords.Add("compare");
            KeyWords.Add("custom");
            KeyWords.Add("distinct");
            KeyWords.Add("equals");
            KeyWords.Add("explicit");
            KeyWords.Add("from");
            KeyWords.Add("group");
            KeyWords.Add("by");
            KeyWords.Add("join");
            KeyWords.Add("into");
            KeyWords.Add("isfalse");
            KeyWords.Add("istrue");
            KeyWords.Add("iterator");
            KeyWords.Add("key");
            KeyWords.Add("mid");
            KeyWords.Add("off");
            KeyWords.Add("order");
            KeyWords.Add("preserve");
            KeyWords.Add("skip");
            KeyWords.Add("while");
            KeyWords.Add("strict");
            KeyWords.Add("take");
            KeyWords.Add("text");
            KeyWords.Add("unicode");
            KeyWords.Add("until");
            KeyWords.Add("where");
            KeyWords.Add("yield");

            // Region & External Source
        }

    }
}