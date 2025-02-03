/*
    Hayden Hartmann
    2/1/2025
    The Four Sisters And The Duckbear
*/

// declaring namespace
namespace The_Four_Sisters_And_The_Duckbear_lvl_7
{
    //creating class
    public class TheFourSistersAndTheDuckbear
    {
        //creating main method
        public static void Main(string[] args)
        {
            //asking user for egg count and converts to int
            Console.Write("Enter number of chocolate eggs collected: ");
            int eggs = Convert.ToInt32(Console.ReadLine());

            //declaring and assigning variables
            int sistersEggsEach = eggs / 4;
            int duckbearEggs = eggs % 4;

            //displays egg count with string injection
            Console.WriteLine($"The sisters get {sistersEggsEach} eggs each");
            Console.WriteLine($"The duckbear gets {duckbearEggs} eggs");

            //The duckbear gets more eggs on count 3, 6, and 7

            //console visibilty 
            Console.ReadKey();
        }
    }
}