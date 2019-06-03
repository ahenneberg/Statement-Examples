/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_Examples
{
    class Program
    {
        static void Main()
        {
            // STATEMENTS:
            /* Functions comprise statements that execute sequentially in the
             textual order in which they appear. A statement block is a series
             of statements appearing between braces (the {} tokens). */
            /* Declaration statements declare a new variable, optionally 
             initializing the variable with an expression. A declaration
             statement ends in a semicolon. You may declare multiple 
             variable of the same type in a comma-separated list.
             For example: */
            string someWord = "rosebud";
            int someNumber = 42;
            bool rich = true, famous = false;
            /* A constant declaration is like a variable declaration, except 
             that it cannot be changed after it has been declared, and the 
             initialization must occur with the declaration. */
            const double c = 2.99792485E08;
            // c += 10; will cause a Compile-time error

            // LOCAL VARIABLES:
            /* The scope of a local variable or local constant extends 
             throughout the current block. You cannot declare another 
             local variable with the same name in the current block 
             or in any nexted blocks. For example: */
            int x;
            {
                int y;
                // int x; causes error - x is already defined. 
            }
            {
                int y;  // OK - y not in scope
            }
            // Console.WriteLine(y) would cause an error - y is out of scope.

            // EXPRESSION STATEMENTS
            /*Expression statements are expressions that are also valid 
             statements. An expression statement must either change state
             or call something that might change state.*/
            /* Changing state means changing a variable. The possible 
             expression statements are: 
             - Assignment expressions (including increment and 
                                       decrement expressions)
             - Method call expressions (both void and nonvoid)
             - Object instantiation expressions*/
            // Here are some examples:
            // Declare variables with declaration statements:
            string s;
            int X, Y;
            StringBuilder sb;
            // Expression statement examples
            X = 1 + 2;                  // Assignment expression
            X++;                        // Increment expression
            Y = Math.Max(X, 5);         // Assignment expression
            Console.WriteLine(Y);       // Method call expression
            sb = new StringBuilder();   // Assignment expression
            new StringBuilder();        // Object instantiation expression
            /*When you call a constructor or a method that returns a value,
             you're not obliged to use the result. However, unless the 
             constructor or method changes state, the statement is
             completely useless: */
            new StringBuilder();        // Legal, but useless
            new string('c', 3);         // Legal, but useless
            X.Equals(Y);                // Legal, but useless

            // SELECTION STATEMENTS
            /* C# has the following mechanisms to conditionally 
             control the flow of program execution:
             - Selection statements (if, switch)
             - Conditional operator (?:)
             - Loop statements (while, do..while, for, foreach) */
        }
    }
}
