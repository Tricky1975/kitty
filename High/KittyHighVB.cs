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
            KeyWords.Add("AddHandler");
            KeyWords.Add("AddressOf");
            KeyWords.Add("Alias");
            KeyWords.Add("And");
            KeyWords.Add("AndAlso");
            KeyWords.Add("As");
            KeyWords.Add("Boolean");
            KeyWords.Add("ByRef");
            KeyWords.Add("Byte");
            KeyWords.Add("ByVal");
            KeyWords.Add("Call");
            KeyWords.Add("Case");
            KeyWords.Add("Catch");
            KeyWords.Add("CBool");
            KeyWords.Add("CByte");
            KeyWords.Add("CChar");
            KeyWords.Add("CDate");
            KeyWords.Add("CDbl");
            KeyWords.Add("CDec");
            KeyWords.Add("Char");
            KeyWords.Add("CInt");
            KeyWords.Add("Class");
            KeyWords.Add("CLng");
            KeyWords.Add("CObj");
            KeyWords.Add("Const");
            KeyWords.Add("Continue");
            KeyWords.Add("CSByte");
            KeyWords.Add("CShort");
            KeyWords.Add("CSng");
            KeyWords.Add("CStr");
            KeyWords.Add("CType");
            KeyWords.Add("CUInt");
            KeyWords.Add("CULng");
            KeyWords.Add("CUShort");
            KeyWords.Add("Date");
            KeyWords.Add("Decimal");
            KeyWords.Add("Declare");
            KeyWords.Add("Default");
            KeyWords.Add("Delegate");
            KeyWords.Add("Dim");
            KeyWords.Add("DirectCast");
            KeyWords.Add("Do");
            KeyWords.Add("Double");
            KeyWords.Add("Each");
            KeyWords.Add("Else");
            KeyWords.Add("ElseIf");
            KeyWords.Add("End");
            KeyWords.Add("Enum");
            KeyWords.Add("Erase");
            KeyWords.Add("Error");
            KeyWords.Add("Event");
            KeyWords.Add("Exit");
            KeyWords.Add("False");
            KeyWords.Add("Finally");
            KeyWords.Add("For");
            KeyWords.Add("Friend");
            KeyWords.Add("Function");
            KeyWords.Add("Get");
            KeyWords.Add("GetType");
            KeyWords.Add("GetXMLNamespace");
            KeyWords.Add("Global");
            KeyWords.Add("GoTo");
            KeyWords.Add("Handles");
            KeyWords.Add("If");
            KeyWords.Add("Implements");
            KeyWords.Add("Imports");
            KeyWords.Add("In");
            KeyWords.Add("Inherits");
            KeyWords.Add("Integer");
            KeyWords.Add("Interface");
            KeyWords.Add("Is");
            KeyWords.Add("IsNot");
            KeyWords.Add("Let");
            KeyWords.Add("Lib");
            KeyWords.Add("Like");
            KeyWords.Add("Long");
            KeyWords.Add("Loop");
            KeyWords.Add("Me");
            KeyWords.Add("Mod");
            KeyWords.Add("Module");
            KeyWords.Add("MustInherit");
            KeyWords.Add("MustOverride");
            KeyWords.Add("MyBase");
            KeyWords.Add("MyClass");
            KeyWords.Add("Namespace");
            KeyWords.Add("Narrowing");
            KeyWords.Add("New Constraint");
            KeyWords.Add("New Operator");
            KeyWords.Add("Next");
            KeyWords.Add("Not");
            KeyWords.Add("Nothing");
            KeyWords.Add("NonInheritable");
            KeyWords.Add("NotOverridable");
            KeyWords.Add("Object");
            KeyWords.Add("Of");
            KeyWords.Add("On");
            KeyWords.Add("Operator");
            KeyWords.Add("Option");
            KeyWords.Add("Optional");
            KeyWords.Add("Or");
            KeyWords.Add("OrElse");
            KeyWords.Add("Out");
            KeyWords.Add("Overloads");
            KeyWords.Add("Overridable");
            KeyWords.Add("Overrides");
            KeyWords.Add("ParamArray");
            KeyWords.Add("Partial");
            KeyWords.Add("Private");
            KeyWords.Add("Property");
            KeyWords.Add("Protected");
            KeyWords.Add("Public");
            KeyWords.Add("RaiseEvent");
            KeyWords.Add("ReadOnly");
            KeyWords.Add("ReDim");
            KeyWords.Add("REM");
            KeyWords.Add("RemoveHandler");
            KeyWords.Add("Resume");
            KeyWords.Add("Return");
            KeyWords.Add("SByte");
            KeyWords.Add("Select");
            KeyWords.Add("Set");
            KeyWords.Add("Shadows");
            KeyWords.Add("Shared");
            KeyWords.Add("Short");
            KeyWords.Add("Single");
            KeyWords.Add("Static");
            KeyWords.Add("Step");
            KeyWords.Add("Stop");
            KeyWords.Add("String");
            KeyWords.Add("Structure Constraint");
            KeyWords.Add("Sub");
            KeyWords.Add("SyncLock");
            KeyWords.Add("Then");
            KeyWords.Add("Throw");
            KeyWords.Add("To");
            KeyWords.Add("True");
            KeyWords.Add("Try");
            KeyWords.Add("TryCast");
            KeyWords.Add("TypeOf");
            KeyWords.Add("UInteger");
            KeyWords.Add("ULong");
            KeyWords.Add("UShort");
            KeyWords.Add("Using");
            KeyWords.Add("When");
            KeyWords.Add("While");
            KeyWords.Add("Widening");
            KeyWords.Add("With");
            KeyWords.Add("WithEvents");
            KeyWords.Add("WriteOnly");
            KeyWords.Add("Xor");

            // Unreserved Keywords

            KeyWords.Add("Aggregate");
            KeyWords.Add("Ansi");
            KeyWords.Add("Assembly");
            KeyWords.Add("Async");
            KeyWords.Add("Auto");
            KeyWords.Add("Await");
            KeyWords.Add("Binary");
            KeyWords.Add("Compare");
            KeyWords.Add("Custom");
            KeyWords.Add("Distinct");
            KeyWords.Add("Equals");
            KeyWords.Add("Explicit");
            KeyWords.Add("From");
            KeyWords.Add("Group");
            KeyWords.Add("By");
            KeyWords.Add("Join");
            KeyWords.Add("Into");
            KeyWords.Add("IsFalse");
            KeyWords.Add("IsTrue");
            KeyWords.Add("Iterator");
            KeyWords.Add("Key");
            KeyWords.Add("Mid");
            KeyWords.Add("Off");
            KeyWords.Add("Order");
            KeyWords.Add("Preserve");
            KeyWords.Add("Skip");
            KeyWords.Add("While");
            KeyWords.Add("Strict");
            KeyWords.Add("Take");
            KeyWords.Add("Text");
            KeyWords.Add("Unicode");
            KeyWords.Add("Until");
            KeyWords.Add("Where");
            KeyWords.Add("Yield");

            // Region & External Source
        }

    }
}