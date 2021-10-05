using System;
using HouseFunction;
// Single line comment

/*
    Multi-line comment
    PascalCase - capitalized words
    camelCase - first word lower, capitalize following words -- naming fields
*/
namespace HelloWorld
{
    class Program
    {
        /*
            the main method is a required method, the program will run this method first.
            - static method does not require instancing the Program class
              - Program test = new Program();
            - void has no return value
        */
        static void Main(string[] args)
        {
            string userInput = "What is your name?";
            string name;
            Console.WriteLine(userInput);
            name = Console.ReadLine();
            if (name == string.Empty)
            {
                name = "World";
            }
            Console.WriteLine($"Hello {name}");

            /*
                House house = new House();
                Console.WriteLine($"Haunted house owner: {house.Owner}");
                Console.WriteLine($"Scary ghost name: {house.Ghost}");
                Console.WriteLine($"Hiding in {house.RoomCount} rooms");
            */
        }
    }
}
