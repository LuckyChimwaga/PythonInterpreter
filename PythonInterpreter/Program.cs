// See https://aka.ms/new-console-template for more information

/*  QUESTION
 Using c#, you are required to create a python interpretor. 
If the last character of a line is  a colon, create a method called lastCharacter that returns true. 
The method should automatically add a space equivalent to space tab in the next line. 
If def is typed, create a method that validates the syntax of a method in python. 
when opening curly braces is part of the code, write a code called isDictionary that returns true.
*/

using System;
using System.Text.RegularExpressions;

class PythonInterpreter
{
    public bool LastCharacter(string line)
    {
        if (line.Trim().EndsWith(":"))
        {
            Console.WriteLine("Last character is a colon (:)");

            // Add 4 spaces (equivalent to a tab) in the next line
            Console.WriteLine(new string(' ', 4)); 
            return true;
        }
        return false;
    }

    public bool ValidateMethodSyntax(string line)
    {
        if (line.Trim().StartsWith("def "))
        {
            //Checks for method syntax
            string pattern = @"^def\s+\w+\s*\([^\)]*\):$";
            return Regex.IsMatch(line, pattern);
        }
        return false;
    }

    public bool IsDictionary(string code)
    {
        return code.Contains("{");

    }
}

class Program
{
    static void Main(string[] args)
    {
        PythonInterpreter interpreter = new PythonInterpreter();

        Console.WriteLine("Enter a line of code:");
        string line1 = Console.ReadLine();

        Console.WriteLine("Enter a method definition:");
        string methodDef = Console.ReadLine();

        Console.WriteLine("Enter code containing a dictionary:");
        string codeWithDictionary = Console.ReadLine();

        bool lastCharResult = interpreter.LastCharacter(line1);
        Console.WriteLine($"Last character is a colon: {lastCharResult}");

        bool methodSyntaxValid = interpreter.ValidateMethodSyntax(methodDef);
        Console.WriteLine($"Method syntax is valid: {methodSyntaxValid}");

        bool hasDictionary = interpreter.IsDictionary(codeWithDictionary);
        Console.WriteLine($"Code contains a dictionary: {hasDictionary}");
    }
}

