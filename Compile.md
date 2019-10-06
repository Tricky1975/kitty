# Compiling Kitty

When you just want the tool I'd recommend to download the binaries from the "releases" tab. When you just want to add Kitty into your own console app, you can just include the files in the "High" folder in any way you see fit. They don't use any dependency code, and most versions of C# (as long as they support Roslyn) should take that.

When you really insist on creating a Kitty.exe file yourself from the source, then here goes.
I used Visual Studio 2017... Not sure if that matters, but to be sure that a wrong VS version is not what strikes you. ;)


First of all create a folder where you want my projects to live in general and from there:
~~~powershell

git clone https://Tricky1975/kitty Kitty
# NOTE: In Windows you can leave the second "Kitty" out, but on Linux I recommend NOT to due to case sensitivity issues

git clone https://github.com/Tricky1975/trickyunits_csharp TrickyUnits

cd TrickUnits

msbuild
# This of course if msbuild is in your path somewhere. and "msbuild" should know by itself that since Kitty.sln is the only solution file, that is the file to compile from.
~~~

Perhaps I should make a project manager for my C# projects 
