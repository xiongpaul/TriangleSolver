/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#2
 * 
 * Purpose: Console Application that works with a Triangle object
 * 
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programLoop = true;
            
            //loop that forces valid menu selection
            do
            {
                //declare variables
                int value;

                //menu on console app
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");

                int.TryParse(Console.ReadLine(), out value);

                switch (value)
                {
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                    case 1:
                        //obtain user input then pass to Analyze method in TriangleSolver class
                        Console.WriteLine("Please enter value for side-a of the triangle");
                        int.TryParse(Console.ReadLine(), out value);
                        int a = value;
                        
                        Console.WriteLine("Please enter value for side-b of the triangle");
                        int.TryParse(Console.ReadLine(), out value);
                        int b = value;
                        
                        Console.WriteLine("Please enter value for side-c of the triangle");
                        int.TryParse(Console.ReadLine(), out value);
                        int c = value;
                        
                        string rcvMsg = TriangleSolver.Analyze(a, b, c);
                        Console.WriteLine(rcvMsg);
                        break;
                    case 2:
                        //exit the program
                        Environment.Exit(0);
                        break;
                }//end of switch block
                
            } while (programLoop);
            //end of loop forces program to run until valid menu selection
        }

    }
    
}
