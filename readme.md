# Kitty

Kitty is just a quick console syntax highlighting tool.
It was written for the .NET framework and it shows and syntax highlights source files (when it can). The approach is very simplistic (intentionally) so one shouldn't expect too great things from it, but it can at least help as a quick solution. It's set up in a modular way to support for more languages should not be that hard.

# Name

The name "Kitty" is a pun to "cat", the unix tool to create and view text files. Although "cat" is not named after the animal but is merely a shortening for "conCAT", it was just a nice play to do. Oh, by the way, my beloved little girl (see picture below) is also named "Kitty"... Isn't she cute?
![Kitty](http://tricky1975.github.io/DevLogs/Dyrt/Icons/kitty.jpg)

# Usage

Kitty will normally recognize the file you want to view with it by its extension, and highlight it, if it has been recognized. It works as simple as this:
~~~PowerShell
Kitty "SourceFile.c" 
~~~

Multiple files are also possible, like this:
~~~PowerShell
Kitty "SourceFile.c" "HeaderFile.h"
~~~

Now Kitty has NO built-in support for wild cards, which can be a bit of a bummer in Windows unless you're using Cygwin I guess.

# MacOS X and Linux

Kitty has been coded in C#, and therefore uses the .NET Framework. When you use programs like Mono, Kitty should work
~~~shell
mono Kitty.exe "SourceFile.c"
# Of course that is if Kitty.exe is in a directory Mono can fine XD
~~~

# Supported Languages

On the moment this document was updated, the next languages were supported:
- BASIC (GW-BASIC and QBASIC) (.bas)
- BlitzBasic (and its variants Blitz3D and BlitzPlus) (.bb)
- BlitzMax (.bmx)
- Brainfuck (.bf)
- C/C++ (.c/.cpp/.h/.hpp)
- C# (.cs)
- GINI (.gini)
- [Go](https://golang.org/) (.go)
- HTML (.html/.htm)
- ini/config (.ini)
- Java (.java)
- JavaScript (.js)
- JSON (.json)
- Lua (.lua)
- [NIL isn't Lua](https://github.com/jpbubble/NIL-isn-t-Lua) (.nil)
- Pascal (.pas)
- Python (.py)
- SAKSIA (.saskia)
- [Scyndi](https://github.com/Wendicka/Scyndi) (.ssf/.scf)
- VisualBasic (.vb)
- Whitespace (.ws)
- XML (.xml)

More might be added later, but no promises yet ;)
