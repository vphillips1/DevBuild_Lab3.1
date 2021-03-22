using System;

namespace Lab3._1StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = { "David", "Andrew", "Jennifer", "April", "Jeff" };

            string[] favoriteFood = { "Muffins", "Chocolate Cookies", "Snickers", "Chips", "Pizza" };

            string[] previousTitle = { "Human Resources", "Customer Support", "Security Guard", "Sales Associate", "Sales Manager" };



            Console.WriteLine("Welcome to our Dev.Build Class.");
            Console.WriteLine("Which student would like to learn more about?");


            bool shouldContinue = true;

            while (shouldContinue)
            {
                try
                {

                    Console.Write("Enter a number 1 - 5:");

                    if (int.TryParse(Console.ReadLine(), out int userSelection) && userSelection < 6)
                    {
                        int userIndex = userSelection - 1;
                        Console.WriteLine($"Student {userSelection} is {name[userSelection - 1]}.");
                    }
                    else
                    {
                        shouldContinue = true;
                        Console.WriteLine(" That student does not exist. Please try again.");
                        continue;
                    }
                    bool again = true;
                    while (again)
                    {
                        Console.WriteLine($"What would you like to know about {name[userSelection - 1]} ? (Enter favorite food or previous title:)");
                        string userChoice = Console.ReadLine();
                        if (userChoice.Equals("previous title", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"{name[userSelection - 1]} previous title was {previousTitle[userSelection - 1]}.");
                            break;
                        }
                        else if (userChoice.Equals("favorite food", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"{name[userSelection - 1]}'s favorite food is {favoriteFood[userSelection - 1]}.");
                            break;
                        }
                        else
                        {
                            again = true;
                            Console.WriteLine("That data does not exist. Please try again.");
                            continue;
                        }
                    }
                    Console.WriteLine("Would you like to know more about another student? (enter yes or no:)");
                    string response = Console.ReadLine();

                    if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))

                    {

                        shouldContinue = true;

                    }

                    else
                    {
                        shouldContinue = false;
                        Console.WriteLine("Thank you! Have a good day.");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter a valid selection.");
                    shouldContinue = true;
                }


            }
        }
    }





}
    

