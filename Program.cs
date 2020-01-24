using System;

namespace Deliverable_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");
            StudentInfo(); //Runs the first method.
        }

        public static bool StudentInfo() // Here's the first method.
        {
            //2D array with all of the info on each student. Jake is [0,(1,2,3)], Andrew is [1,(1,2,3)]   
            string[,] students = new string[6, 3]
            {
            {"Jake Collins", "Corona CA", "Sushi"},
            {"Andrew Waltman","Grand Rapids, MI","Burgers"},
            {"Albert Ngoudjou","Bafoussam","Lasagna"},
            {"Tommy Waalkes","Raleigh NC","Indian Chicken Curry"},
            {"Austin Powel","Blissfield, MI","Spaghetti"},
            {"Dylan Rule","Newport, NH","Poutine"}
            };

            Console.WriteLine("Please input a number between 1-6 to recieve a Student's information.");
            string input1 = Console.ReadLine();
            
            //This is the start of the string input into the arrays segment. Part 1.
            string part1 = input1;

            switch (part1)
            {
                case "1":
                    Console.WriteLine("That student is "+ students[0,0] + ". What else would you like to know about Jake?");
                    break;
                case "2":
                    Console.WriteLine("That student is " + students[1,0] + ". What else would you like to know about Andrew?");
                    break;
                case "3":
                    Console.WriteLine("That student is " + students[2,0] + ". What else would you like to know about Albert?");
                    break;
                case "4":
                    Console.WriteLine("That student is " + students[3,0] + ". What else would you like to know about Tommy?");
                    break;
                case "5":
                    Console.WriteLine("That student is " + students[4,0] + ". What else would you like to know about Austin?");
                    break;
                case "6":
                    Console.WriteLine("That student is " + students[5,0] + ". What else would you like to know about Dylan?");
                    break;
            }
            return ProgressYN();

        }
        public static bool ProgressYN()
        {
            Console.WriteLine("Would you like to continue? (Y/N)");
            string response = Console.ReadLine().ToLower().Trim();
            if(response == "y")
            {
                return StudentInfo();
            }
            else if(response == "n")
            {
                return false;
            }
            else
            {
                return ProgressYN();
            }
        }
    }
}

