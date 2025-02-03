/*
    Hayden Hartmann
    1/31/2025
    Repairing The Clocktower
*/

// declaring namespace
namespace Repairing_The_Clocktower_lvl_9
{
    //creating class
    public class RepairingTheClocktower
    {
        //creating main method
        public static void Main(string[] args)
        {
            //asking for int input then converting string to int
            Console.Write("Enter a number to display Tik or Tok for the watchtower: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //if else statement to determin Tik or Tok, number % 2 == 0 if number is even, else odd
            if (number % 2 == 0)
            {
                Console.WriteLine("Tik");
            }
            else
            {
                Console.WriteLine("Tock");
            }
            //console visibilty 
            Console.ReadKey();
        }
    }
}







