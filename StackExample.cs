using System;
using System.Collections;
public class SamplesStack
{

    public static void Main()
    {

        //Create and initializes a new stack
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");

        //Display the properties and values of the stack.
        Console.WriteLine("myStack");
        Console.WriteLine("\tCount:     {0}", myStack.Count );
        Console.Write("\tValues:");
        PrintValues(myStack);
    }

    public static void PrintValues( IEnumerable myCollection)
    {
        foreach (object obj in myCollection)
            Console.Write("     {0}", obj);
        Console.WriteLine();
        Console.ReadKey();
    }
}
