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
            House house = new House();

            string userInput = "What is the Haunted House owner's name?";
            Console.WriteLine(userInput);
            string name = Console.ReadLine();
            
            if (name != string.Empty)
            {
                house.Owner = name;
            }

            Console.WriteLine($"{house.Owner} is hiding from {house.Ghost} in {house.RoomCount} rooms");

            house.Ghost = "Harry Houdini";
            Console.WriteLine($"{house.Ghost} just appeared!");
        }
    }
}
