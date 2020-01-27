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

            //Beginning of the method with a question and a string input.
            Console.WriteLine("Please input a number between 1-6 to recieve a Student's information.");
            string input1 = Console.ReadLine().Trim();

            //This is the start of the string input into the arrays segment. Tells us which students that will be asked about.
            string part1 = input1;

            switch (part1)
            {
                case "1":
                    Console.WriteLine("That student is "+ students[0,0] + ". What else would you like to know about Jake?");
                    Console.WriteLine("(Enter 'Hometown' or 'Favorite Food' to learn more.");
                    string input2 = Console.ReadLine().ToLower().Trim();
                    if(input2 == "hometown")
                    {
                        Console.WriteLine("Jake's hometown is " + students[0,1] +".");
                        return ProgressYN();
                    }
                    else if(input2 == "favorite food")
                    {
                        Console.WriteLine("Jake's favorite food is " + students[0,2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                case "2":
                    Console.WriteLine("That student is " + students[1,0] + ". What else would you like to know about Andrew?");
                    input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine("Andrew's hometown is " + students[1, 1] + ".");
                        return ProgressYN();
                    }
                    else if (input2 == "favorite food")
                    {
                        Console.WriteLine("Andrew's favorite food is " + students[1, 2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                case "3":
                    Console.WriteLine("That student is " + students[2,0] + ". What else would you like to know about Albert?");
                    input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine("Albert's hometown is " + students[2, 1] + ".");
                        return ProgressYN();
                    }
                    else if (input2 == "favorite food")
                    {
                        Console.WriteLine("Albert's favorite food is " + students[2, 2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                case "4":
                    Console.WriteLine("That student is " + students[3,0] + ". What else would you like to know about Tommy?");
                    input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine("Tommy's hometown is " + students[3, 1] + ".");
                        return ProgressYN();
                    }
                    else if (input2 == "favorite food")
                    {
                        Console.WriteLine("Tommy's favorite food is " + students[3, 2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                case "5":
                    Console.WriteLine("That student is " + students[4,0] + ". What else would you like to know about Austin?");
                    input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine("Austin's hometown is " + students[4, 1] + ".");
                        return ProgressYN();
                    }
                    else if (input2 == "favorite food")
                    {
                        Console.WriteLine("Austin's favorite food is " + students[4, 2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                case "6":
                    Console.WriteLine("That student is " + students[5,0] + ". What else would you like to know about Dylan?");
                    input2 = Console.ReadLine().ToLower().Trim();
                    if (input2 == "hometown")
                    {
                        Console.WriteLine("Dylan's hometown is " + students[5, 1] + ".");
                        return ProgressYN();
                    }
                    else if (input2 == "favorite food")
                    {
                        Console.WriteLine("Dylan's favorite food is " + students[5, 2] + ".");
                        return ProgressYN();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that information is invalid. Please try again.");
                        return StudentInfo();
                    }
                default:
                    Console.WriteLine("That was not a valid response, please try again.");
                    return StudentInfo();
            }
            //Default: returns any inproper response from input1 back to the start and asks again.
        }
        public static bool ProgressYN()
        {
            Console.WriteLine("Would you like to know about another student? (Y/N)");
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

