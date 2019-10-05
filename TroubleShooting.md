# Troubleshooting

There are some issues with Kitty, and I didn't expect that elseway.
First of all check the [Issue Tracker](https://github.com/Tricky1975/kitty/issues), where issues that are bound to be fixed will be addressed properly.

These are issues I will NEVER fix, and I'll explain why

## Whitespace leads to funny results

Whitespace technically does that what many tools avoid for many reasons. Making use of tabs and spaces. And since a lot of tools try not to bother these for reasons of being clean or avoiding needless RAM usage, and many other reasons, Whitespace can sometimes cause these intelligent features to trigger. Not a problem in a NORMAL programming language, but esolangs are never NORMAL, and WhiteSpace in particular is nasty for this reason. In the normal cmd and powershell windows Whitespace programs should display, as long as you don't resize your window. I do not know about Linux and MacOS, as I never tried (and don't plan to either). I used an advanced program for my console work in PowerShell, and there the tabs are not shown... figures...
I hope it goes without saying, that these issues are out of my hands, and since Whitespace is only an esolang, I don't think I should even BOTHER fixing that even if I could.

## Some old BASIC programs show funny results

That is an "issue" in BASIC. For some reasons beyond me (saving space is my guess) GW-BASIC, BASICA and other old BASIC interpreters don't save their source code as a plain text file, like C, C++, Pascal and many other programming languages do. This is not something I can "fix" as this is just how these old interpreters save those files. Now I know that when you load a file in GW-BASIC you can give this command to make it being saved in ASCII code:
~~~
SAVE "MYPROG.BAS",A
~~~
And then Kitty will be able to take it up. The same issue will (so I found out) also arise with AMOS if I ever support that language in Kitty. Kitty can only access plain text, and I don't intend to change that.

## Some words marked as keywords aren't and vice versa.

Particulary with BASIC this can happen. There's hardly a language imaginable with that many dialects as BASIC, and I think it will even outrank C on this department. However where most dialects of C have completely different names and extensions, the extension .bas, has been common for GW-BASIC, BASICA, older versions of Visual BASIC, Free Basic, and many more. I hope you realize that it would be undoable to cover all these variants properly when .bas is the only way to recognize them. Even Visual BASIC used .bas in the past (although .vb is more common in modern version, thank goodness). So I had to pick as standard and I decided QBASIC had to be .bas
Most programs written in GW-BASIC and even in BASIC variants for old home computers should be covered with that, although some keywords, like "DECLARE", "SUB" and "FUNCTION" came to BASIC in QBASIC and is not present in older versions, and QBASIC was also one of the first without the line number requirement to prefix every line with (something later dialects didn't support at all). And I wonder if the "DEF" keyword, which was in older BASIC versions a very primitive way to define functions (not even close to what modern BASIC versions can do), may even have vanished from many dialects now. 
I took NIBBLES.BAS, a game to demonstrate QBASIC even coded by Microsoft, as my standard. If NIBBLES.BAS would do I should consider BASIC as "supported". And hopefully most other dialects will use their own extensions....

In languages such as C, C++, Pascal, Go etc., you gotta note that these languages change too. I am really not sure if program coded in the first version of C would still work when using a C99 compiler (vice versa very likely not). And in Pascal for example, the DOS and Windows 3.11 compilers the keywords "near" and "far" were used to address the compiler to do stuff that would produce better results on 16bit processors, but since mordern 32/64bit processors don't even support those features those keywords became obsolete, and the first versions of C had no support for the "void" keyword or for single line comments, which modern versions have. Now most languages (except JavaScript maybe, which changes more than the weather) do not change that much anymore so overall Kitty should not notice many issues, but sometimes some changes can cause Kitty to "malfunction" due to stuff being removed or added over time. I hope you don't expect me to keep myself updated every day, and that there's no way for Kitty to tell which compiler version you use.

## Why isn't ClickTeam Fusion supported?

Do you really need to ask? 
I'll only do plain text files. A "codeless" programming languages such as CTF, does (logically) not create such files.

