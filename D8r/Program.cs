using System;

namespace D8r
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

            sam.SetHobbies(new string[] { "going to the store", "going for a walk", "going to the movies" });

            Profile ellie = new Profile("Ellie Minkel", 27, "New York", "USA");
            ellie.SetHobbies(new string[] { "zoom with friends", "cooking", "online shopping" });

            Profile kelly = new Profile("Kelly Thompson", 28, "Long Island", "USA", "he/him");
            kelly.SetHobbies(new string[] { "sk8ing", "watching old Kung-Fu movies", "pondering the meaning of life" });

            Console.WriteLine("Welcome to D8R");
            Console.Write("Are you 18? Answer y or n:  ");
            string age = Console.ReadLine();

            if (age == "n")
            {
                Console.WriteLine("Come back when you are 18!!!");
            }
            else

            {
                Console.WriteLine("Welcome to D8R");

                void choiceMethod()
                {


                    Console.WriteLine("Active users are sam, ellie, and kelly.");
                    Console.WriteLine("Enter one of their names to view their profile:");
                    string selection = Console.ReadLine();
                    if (selection == "sam")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Here is Sam's profile.");
                        Console.WriteLine(sam.ViewProfile());
                        Console.WriteLine("Would you like to view another profile? Enter yes or no.");
                        string answer = Console.ReadLine();

                        if (answer == "yes")
                        {
                            choiceMethod();
                        } else if (answer == "no")
                        {
                            Environment.Exit(0);
                        } else
                        {
                            Console.WriteLine("You aren't taking your dating life seriously. Goodbye");
                        }

                    }
                    else if (selection == "ellie")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Here is Ellie's profile.");

                        Console.WriteLine(ellie.ViewProfile());

                        Console.WriteLine("Would you like to view another profile? Enter yes or no.");
                        string answer = Console.ReadLine();

                        if (answer == "yes")
                        {
                            choiceMethod();
                        }
                        else if (answer == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("You aren't taking your dating life seriously. Goodbye");
                        }
                    }
                    else if (selection == "kelly")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Here is Kelly's profile.");
                        Console.WriteLine(kelly.ViewProfile());

                        Console.WriteLine("Would you like to view another profile? Enter yes or no.");
                        string answer = Console.ReadLine();

                        if (answer == "yes")
                        {
                            choiceMethod();
                        }
                        else if (answer == "no")
                        {
                            Console.WriteLine("Thank you for using D8R! Goodbye!");
                            Environment.Exit(0);
                        }
                        else

                        {
                            Console.WriteLine("You aren't taking your dating life seriously.Goodbye!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an active user");
                        choiceMethod();
                    }
                }
                choiceMethod();
            }






        }
    }
}
