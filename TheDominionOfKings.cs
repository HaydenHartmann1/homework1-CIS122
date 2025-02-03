/*
    Hayden Hartmann
    1/31/2025
    The Dominion Of Kings
*/

// declaring namespace
namespace The_Dominion_Of_Kings_lvl_7
{
    //creating class
    public class TheDominionOfKings
    {
        //creating main method
        public static void Main(string[] args)
        {
            //asks user to input number of provinces and converts to int
            Console.Write("How many provinces do you have: ");
            int provinces = Convert.ToInt32(Console.ReadLine());

            //asks user to input number of duchies and converts to int
            Console.Write("How many duchies do you have: ");
            int duchies = Convert.ToInt32(Console.ReadLine());

            //asks user to input number of estates and converts to int
            Console.Write("How many estates do you have: ");
            int estates = Convert.ToInt32(Console.ReadLine());

            //calculates total (provinces=1, duchies=3, estates=6)
            int total = provinces + (duchies * 3) + (estates * 6);

            //displays info with string injection
            Console.WriteLine($"Your total score is: {total}");

            //console visibilty 
            Console.ReadKey();
        }
    }
}