using System;
using System.Xml.Schema;

namespace TileCost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a Tile Cost Calculator. Calculate the cost of flooring based on total area, labor and material cost.");

            //Set shape of room
            Console.WriteLine();
            Console.WriteLine("To start, select a room shape:");
            Console.WriteLine("1. For rectangular rooms.");
            Console.WriteLine("2. For non-rectangular rooms.");
            Console.Write("Enter your choice (1 or 2): ");
            string shape = Console.ReadLine();
            int roomShape = Int32.Parse(shape);
            float area = 0;

            //Error handling for when option 1 or 2 is NOT selected.. 
            if (roomShape == 1 || roomShape == 2)
            {

                //Rectangular room calcuation
                if (roomShape == 1)
                {
                    //Set Width
                    Console.Write("Enter the width of the room: ");
                    string widthInput = Console.ReadLine();
                    int width = Int32.Parse(widthInput);

                    //Set Length
                    Console.Write("Enter the lenth of room: ");
                    string lengthInput = Console.ReadLine();
                    int length = Int32.Parse(lengthInput);

                    //Calculate area of the rectangular room
                    area = width * length;
                }

                //Non-Rectangular room calculations (Triangle and Circle)
                if (roomShape == 2)
                {
                    //Set shape of non-rectangular room
                    Console.WriteLine();
                    Console.WriteLine("Okay, so the room is non-rectangular.");
                    Console.WriteLine("To start, select a room shape:");
                    Console.WriteLine("1. For triangular rooms.");
                    Console.WriteLine("2. For circular rooms.");
                    Console.Write("Enter your choice (1 or 2): ");
                    string nonRectShape = Console.ReadLine();
                    int nonRectRoomShape = Int32.Parse(nonRectShape);
                    
                    //Did not implement error handling here

                    //Triangular room calcuation
                    if (nonRectRoomShape == 1)
                    {
                        Console.WriteLine("To calculate the area of a triangle, width must by multipled by length, then dividied by 1/2. ");
                        Console.WriteLine();
                        //Set Width
                        Console.Write("Enter the width of the room: ");
                        string width = Console.ReadLine();
                        int widthTriangle = Int32.Parse(width);

                        //Set Length
                        Console.Write("Enter the lenth of room: ");
                        string length = Console.ReadLine();
                        int lengthTriangle = Int32.Parse(length);

                        //Calculate area of the triangle
                        area = lengthTriangle * lengthTriangle;
                    }

                    //Circle room calcuation
                    if (nonRectRoomShape == 2)
                    {
                        Console.WriteLine("To calculate the area of a circle, pie is multipled by radius squared. ");

                        //Set Radius
                        Console.Write("Enter the radius of the circular room: ");
                        string radius = Console.ReadLine();
                        float radiusCircle = float.Parse(radius);

                        //Calculate area of the circle
                        area = (float)(radiusCircle * 2 * 3.14);
                    }
                }

                //Set cost per unit
                Console.Write("Enter the cost per unit of flooring for room: ");
                string cost = Console.ReadLine();
                float costPerUnit = float.Parse(cost);

                //Calculate cost of materials
                float materialCost = area * costPerUnit;

                //Output cost of materials
                Console.WriteLine();
                Console.WriteLine("Cost of materials: $" + materialCost);
                Console.WriteLine();

                //Calculate labor cost based on hours of labor required
                float laborHours = area / 20;
                float hourlyRate = 86; // Hourly rate of $20 per hour
                float laborCost = laborHours * hourlyRate;

                //Output cost of labor
                Console.WriteLine("Cost of labor: $86/hr * " + laborHours + " hours = $" + laborCost);
                Console.WriteLine();

                //Output Total Cost
                float totalCost = laborCost + materialCost;
                Console.WriteLine("Total cost: $" + totalCost);
            }
            else
            {
                Console.WriteLine("Your input does not match a room type. Close and run the program again.");
            }
        }
    }
}