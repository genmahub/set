using System;

public class Program
{
    public static void Main()
    {
        //first
        Console.WriteLine("This is the first line");

        //second
        Console.Write("This is");
        Console.Write("the second");
        Console.Write("line");
    }
}

/*The Console part is called a class. Classes "own" methods; or you could say that methods live inside of a class. To visit the method, you 
must know which class it's in. For now, think of a class as a way to represent an object. In this case, all of the methods that operate on 
your output console are defined inside of the Console class.

There's also a dot (or period) that separates the class name Console and the method name WriteLine(). The period is the member access operator. 
In other words, the dot is how you "navigate" from the class to one of its methods.

The WriteLine() part is called a method. You can always spot a method because it has a set of parentheses after it. Each method has one job. 
The WriteLine() method's job is to write a line of data to the output console. The data that's printed is sent in between the opening and 
closing parenthesis as an input parameter. Some methods need input parameters, while others don't. But if you want to invoke a method, you must 
always use the parentheses after the method's name. The parentheses are known as the method invocation operator.

Finally, the semicolon is the end of statement operator. A statement is a complete instruction in C#. The semicolon tells the compiler that 
you've finished entering the command.

Use Console.WriteLine("Your message here");
Capitalize Console, Write, and Line
Use the correct punctuation because it has a special role in C#
If you make a mistake, just spot it, fix it and re-run*/
