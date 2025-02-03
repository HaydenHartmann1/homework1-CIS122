/*
    Hayden Hartmann
    1/31/2025
    The Defence Of Consolas
*/

// declaring namespace
namespace The_Defence_Of_Consolace_lvl_8
{
    //creating class
    public class TheDefenceOfConsolas
    {
        //creating main method
        public static void Main(string[] args)
        {
            //displays info to user and changes title
            Console.Title = "Defence of Consolas";
            Console.WriteLine("Enter A position you would like to defend");

            //asks user to input row, then converts to int
            Console.Write("Target Row (int): ");
            int row = Convert.ToInt32(Console.ReadLine());

            //asks user to input column, then converts to int
            Console.Write("Target Column (int): ");
            int column = Convert.ToInt32(Console.ReadLine());

            //deployment positions
            Console.WriteLine("Deploy to:");

            Console.BackgroundColor = ConsoleColor.Red;   //console color changer with enumeration
            Console.WriteLine($"({row + 1}, {column})");  //one above 

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"({row - 1}, {column})");  //one below

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"({row}, {column + 1})");  //one to left

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"({row}, {column - 1})");  //one to right

            //makes beeping sound
            Console.Beep();

            //console visibilty 
            Console.ReadKey();
        }
    }
}