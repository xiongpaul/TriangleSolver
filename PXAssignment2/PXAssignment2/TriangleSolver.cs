/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#2
 * 
 * Purpose: class file that defines the TriangleSolver object
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PXAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int num1, int num2, int num3)
        {
            //declare variables used by method
            string msg;
            string triType;
            int a = num1;
            int b = num2;
            int c = num3;

            //determines if the values passed are positive integer
            if (a <= 0 || b <= 0 || c <= 0)
            {
                msg = "An invalid value was provided.\n" +
                    "All values provided must be greater than 0\n" +
                    "Please check inputs and try again\n";
            }
            else
            {
                //determines if the object is a triangle
                if ((a + b) > c)
                {
                    //determines triangle type
                    if (a == b & b == c)
                    {
                        triType = "an equilateral";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        triType = "an isoceles";
                    }
                    else
                    {
                        triType = "a scalene";
                    }
                    msg = "YES! The values provided do indeed form a triangle\n" +
                        "The values provided form " + triType + " triangle\n";
                }
                else
                {
                    msg = "NO! The values provided do NOT form a triangle\n" +
                        "according to the formula:\n(a + b) > c\n";
                }
            }
            //returns the message that was created
            return msg;            
        }        
    }    
}
