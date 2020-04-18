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
Extension | Language | Added by: | Notes:
---|---|---|---
bas | BASIC/GW-BASIC/QBASIC | Jeroen P. Broks | Please note that due to the many variants of this language the highlight can sometimes be faulty.
bb | BlitzBasic | Jeroen P. Broks | This includes its variants Blitz3D and BlitzPlus
bmx | BlitzMax | Jeroen P. Broks 
bf | Brainfuck | Jeroen P.Broks | Esolang
c/cpp/h/hpp | C/C++ | Jeroen P. Broks
cs | C# | Jeroen P. Broks
gini | GINI | Jeroen P. Broks
go | [Go](https://golang.org/) | Jeroen P. Broks
html/htm | HTML | Freezernick
ini | ini/config | Jeroen P. Broks
java | Java | Jeroen P. Broks
js | JavaScript | Jeroen P. Broks
json | JSON | Jeroen P. Broks
lua | Lua | Jeroen P. Broks
nil | [NIL isn't Lua](https://github.com/jpbubble/NIL-isn-t-Lua) | Jeroen P. Broks
pas | Pascal | Jeroen P. Broks
py | Python | Jeroen P. Broks
saskia | SAKSIA | Jeroen P. Broks
scf/ssf | [Scyndi prototype](https://github.com/Wendicka/Scyndi) | Jeroen P. Broks | This language will be entirely revised and then this format may get deprecated!
vb | VisualBasic | Freezernick
ws | Whitespace | Jeroen P. Broks | Depending on the used console software, this may not work on your system or not well. 
xml | XML | Freezernick | This also triggers C# and Visual C++ projects and XAML files

More might be added later, but no promises yet ;)
