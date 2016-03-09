﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_BreakpointsAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Visual Studio gvies us many tools to help identify and eliminate bugs in our code
            //The first tool I will go over are breakpoints
            //Placing a breakpoint in code will pause code execution when that breakpoint is reached
            //We can insert a breakpoint by pressing f9 on the line of code where we want the breakpoint
            //or we can click the grey area to the left of the code where we want a breakpoint
            bool breakHere = true;

            if (breakHere)
            {
                //do some code
            }

            //we can navigate through breakpoints using the f5, f10 and f11 keys
            //f5 will continue until the next breakpoint is reached
            //f10 will step to the next line of code
            //f11 will step into methods

            //breakpoints are extremely useful when debugging as it allows us to see exactly what is going on in our code at run time
            //we can peak variable values and expressions by hovering over them or we can use other tools, like the immediate window

            //the immediate window
            //when we are debugging we can type or paste code into the immediate window, press enter, and it will compute the variable value
            //or expression result. This is a one time execution, what if we wanted to track a variables value as we step through our code?
            //we can use watchers to do this

            //watchers
            //We can add a watcher to variables simply by right clicking the variable and clicking add watch
            //this will display the variable in the watch window, and values that change will highlight red
            //lets add a watcher to the variable below
            int watchThisInt = 0;
            for (int i = 0; i < 5; i++)
            {
                watchThisInt++;
            }

            //ErrorList and Output
            //at compile time, the compiler will give us warnings and errors that it detects in out code in the error list or output boxes
            
            //removing the comment of the below line will produce a warning in the error list
            //int isNotUsed = 0;

            //removing the comment in the below line will produce an error
            //int willError = "this will cause an error";
        }
    }
}
