//Author: DEthan lERAY
//Date: 1/29/2021
//Comments: This code will demonstrate the use of conditional statements.
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input
            Console.WriteLine("What Grade do you Expect to get in ISM 4300?");
            //
           string input = Console.ReadLine();
            //Convert string input to a decimal
           decimal average = decimal.Parse(input);

            //Initialize grade to an empty value
             string grade = "";
            //Determine what the grade is based on the given score using conditional statements. 
            //Grades come from syllabus scale.
                if(average >= 98) 
                {
                    grade = "A+";
                }
                else if (average >= 92)
                 {
                    grade = "A";
                 }
                else if (average >= 90)
                 {
                     grade = "A-";
                 }
                else if (average >= 88)
                 {
                     grade = "B+";
                 }
                else if (average >= 82)
                 {
                    grade = "B";
                 }
                else if (average >= 80)
            {
                grade = "B-";
            }
                else if (average >= 78)
            {
                grade = "C+";
            }
                else if (average >= 72)
            {
                grade = "C";
            }
                else if (average >= 70)
            {
                grade = "C-";
            }
                else if (average >= 68)
            {
                grade = "D+";
            }
                else if (average >= 62)
            {
                grade = "D";
            }
                else if (average >= 60)
            {
                grade = "D-";
            }
                else
            {
                grade = "F";
            }
            //Display what the grade will be based on the given score
            Console.WriteLine("Your grade will be " + grade);
           
            Console.ReadKey(true);
        }
    }
}
