/*
    Hayden Hartmann
    2/1/2025
    The Triangle Farmer
*/

// declaring namespace
namespace The_Triangle_Farmer_lvl_7
{
    //creating class
    public class TheTriangleFarmer
    {
        //creating main method
        public static void Main(string[] args)
        {
            //asks user to input base and converts to double
            Console.Write("Enter triangle base: ");
            double triangleBase = Convert.ToDouble(Console.ReadLine());

            //asks user to input height and converts to double
            Console.Write("Enter triangle height: ");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());

            //delcare and assign area
            double area = (triangleBase * triangleHeight) / 2;

            //display area
            Console.WriteLine($"The area of the triangle is: {area}");

            //console visibilty 
            Console.ReadKey();
        }
    }
}