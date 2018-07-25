/*
 * Name: Paul Xiong
 * Course: PROG2070
 * Assignment#2
 * 
 * Purpose: Unit Tests for TriangleSolver object
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PXAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        //Test#1
        //Invalid input values, with a zero parameter
        [Test]
        public void AnalyzeMethod_Given3And3And0_ResultIsInvalidValuesMessage()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 0;

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);
            
            //Assert
            StringAssert.AreEqualIgnoringCase("An invalid value was provided.\n" +
                    "All values provided must be greater than 0\n" +
                    "Please check inputs and try again\n", msg);
        }

        //Test#2
        //Invalid input values, with a negative integer parameter
        [Test]
        public void AnalyzeMehtod_Given87And34AndNegative44_ResultIsInvalidValuesMessage()
        {
            //Arrange
            int a = 87;
            int b = 34;
            int c = -44;

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.AreEqualIgnoringCase("An invalid value was provided.\n" +
                    "All values provided must be greater than 0\n" +
                    "Please check inputs and try again\n", msg);
        }

        //Test#3
        //Valid input values, but no triangle formed
        [Test]
        public void AnalyzeMethod_Given2And2And8_ResultIsNoTriangleFormedMessage()
        {
            //Arrange
            int a = 2;
            int b = 2;
            int c = 8;

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.AreEqualIgnoringCase("NO! The values provided do NOT form a triangle\n" +
                        "According to the formula:\n(a + b) > c\n", msg);
        }

        //Test#4
        //Valid input values, equilateral triangle formed
        [Test]
        public void AnalyzeMethod_Given3And3And3_ResultIsEquilateralTriangleMessage()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 3;
            string triType = "an equilateral";

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.AreEqualIgnoringCase("YES! The values provided do indeed form a triangle\n" +
                        "The values provided form " + triType + " triangle\n", msg);
        }

        //Test#5
        //Valid input values, isoceles triangle formed
        [Test]
        public void AnalyzeMethod_Given9And9And8_ResultIsIsocelesTriangleMessage()
        {
            //Arrange
            int a = 9;
            int b = 9;
            int c = 8;
            string triType = "an isoceles";

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.AreEqualIgnoringCase("YES! The values provided do indeed form a triangle\n" +
                        "The values provided form " + triType + " triangle\n", msg);
        }

        //Test#6
        //valid input values, scalene triangle formed
        [Test]
        public void AnalyzeMethod_Given8And12And10_ResultIsScaleneTriangleMessage()
        {
            //Arrange
            int a = 8;
            int b = 10;
            int c = 12;
            string triType = "a scalene";

            //Act
            string msg = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.AreEqualIgnoringCase("YES! The values provided do indeed form a triangle\n" +
                        "The values provided form " + triType + " triangle\n", msg);
        }
    }
}
